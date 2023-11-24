namespace MassTransit.AmazonSqsTransport.Tests
{
    using System.Threading.Tasks;
    using NUnit.Framework;
    using PublishSpecs;


    namespace PublishSpecs
    {
        public interface MessageOne
        {
        }


        public interface MessageTwo
        {
        }
    }


    [TestFixture]
    public class When_publishing_messages_from_the_bus :
        AmazonSqsTestFixture
    {
        [Test]
        public async Task Should_support_multiple_types()
        {
            await Bus.Publish<MessageOne>(new { });

            await Bus.Publish<MessageTwo>(new { });
        }
    }
}
