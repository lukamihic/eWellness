using eWellness.Core.Enums;

namespace eWellness.BL.Common
{
    public interface IRabbitMQProducer
    {
        public void SendEmailMessage(object message, MailTypeEnum mailType);
    }
}
