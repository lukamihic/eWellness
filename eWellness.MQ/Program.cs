using eWellness.Core.Enums;
using eWellness.Core.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

//Here we specify the Rabbit MQ Server. we use rabbitmq docker image and use it
var factory = new ConnectionFactory
{
    HostName = "localhost"
};
//Create the RabbitMQ connection using connection factory details as i mentioned above
var connection = factory.CreateConnection();
//Here we create channel with session and model
using
var channel = connection.CreateModel();
//declare the queue after mentioning name and a few property related to that
channel.QueueDeclare("email", exclusive: false);
//Set Event object which listen message from chanel which is sent by producer
var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, eventArgs) =>
{
    var body = eventArgs.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"Product message received: {message}");
    dynamic deserialized = JsonConvert.DeserializeObject(message) ?? new { };
    var client = new HttpClient();
    var mailType = Convert.ToInt16(deserialized[1].MailType);

    switch (int.Parse(mailType.ToString()))
    {
        case (int)MailTypeEnum.NewAppointment:
            break;
        case (int)MailTypeEnum.NewUser:
            var userInfo = new
            {
                name = deserialized[0].User.Name,
                email = deserialized[0].User.Email,
                phone = deserialized[0].User.Phone,
                address = deserialized[0].User.Address,
                emergencyContactPhone = deserialized[0].User.EmergencyContactPhone,
                emergencyContactName = deserialized[0].User.EmergencyContactName,
                gender = deserialized[0].User.Gender,
                dateOfBirth = deserialized[0].User.DateOfBirth
            };
            //var userInfo = (object)deserialized[0]["User"];
            var json = JsonConvert.SerializeObject(userInfo);



            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            client.PostAsync("https://localhost:7085/api/Mailer/welcome", byteContent);
            break;
        default:
            break;
    }
};
//read the message
channel.BasicConsume(queue: "email", autoAck: true, consumer: consumer);
Console.ReadKey();