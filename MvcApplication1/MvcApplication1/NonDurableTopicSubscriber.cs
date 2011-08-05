using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;

namespace MvcApplication1
{
    public delegate void MessageReceivedDelegate(string message);

    public class NonDurableTopicSubscriber : IDisposable
    {
        private readonly string topicName = null;
        private readonly IConnectionFactory connectionFactory;
        private readonly IConnection connection;
        private readonly ISession session;
        private readonly IMessageConsumer consumer;
        private bool isDisposed = false;
        public event MessageReceivedDelegate OnMessageReceived;

        public NonDurableTopicSubscriber(string topicName, string brokerUri, string clientId)
        {
            this.topicName = topicName;
            this.connectionFactory = new ConnectionFactory(brokerUri);
            this.connection = this.connectionFactory.CreateConnection();

            try
            {
                this.connection.ClientId = clientId;
                if (this.connection.IsStarted)
                    connection.Stop();

                this.connection.Start();
                this.session = connection.CreateSession();
                ActiveMQTopic topic = new ActiveMQTopic(topicName);
                this.consumer = this.session.CreateConsumer(topic, "2 > 1", false);
                this.consumer.Listener += new MessageListener(OnMessage);
            }
            catch
            {
            }
        }

        public void OnMessage(IMessage message)
        {
            ITextMessage textMessage = message as ITextMessage;
            if (this.OnMessageReceived != null)
            {
                this.OnMessageReceived(textMessage.Text);
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (!this.isDisposed)
            {
                this.consumer.Dispose();
                this.session.Dispose();
                this.connection.Dispose();
                this.isDisposed = true;
            }
        }

        #endregion

    }
}