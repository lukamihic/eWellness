﻿using eWellness.BL.Common;
using eWellness.Core.Enums;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace eWellness.BL
{
    public class RabbitMQProducer : IRabbitMQProducer
    {
        public RabbitMQProducer()
        {
        }
        public void SendEmailMessage(object message, MailTypeEnum mailType) {
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
            //Serialize the message
            var obj = new []{ message, new { MailType = mailType} };
            var json = JsonConvert.SerializeObject(obj);
            var body = Encoding.UTF8.GetBytes(json);
            //put the data on to the product queue
            channel.BasicPublish(exchange: "", routingKey: "email", body: body);
        }

    }
}
