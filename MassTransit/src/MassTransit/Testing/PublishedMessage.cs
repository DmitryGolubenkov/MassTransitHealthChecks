namespace MassTransit.Testing
{
    using System;


    public class PublishedMessage<T> :
        IPublishedMessage<T>
        where T : class
    {
        readonly PublishContext<T> _context;

        public PublishedMessage(PublishContext<T> context, Exception exception = null)
        {
            _context = context;
            Exception = exception;

            ElementId = _context.MessageId;

            StartTime = context.SentTime ?? DateTime.UtcNow;
            ElapsedTime = DateTime.UtcNow - StartTime;
        }

        public Guid? ElementId { get; }
        SendContext IPublishedMessage.Context => _context;
        public DateTime StartTime { get; }
        public TimeSpan ElapsedTime { get; }
        public Exception Exception { get; }
        public Type MessageType => typeof(T);
        public string ShortTypeName => TypeCache<T>.ShortName;
        object IPublishedMessage.MessageObject => _context.Message;
        PublishContext<T> IPublishedMessage<T>.Context => _context;
    }
}
