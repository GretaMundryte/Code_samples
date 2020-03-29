using NUnit.Framework;
using HtmlGenerator;

namespace HtmlGeneratorTest
{
    public class CommentsTest
    {
        private CommentsRenderer Renderer;
        
        [SetUp]
        public void Setup()
        {
            Renderer = new CommentsRenderer();
        }

        [Test]
        public void ReturnsEmpty()
        {
            Assert.AreEqual("", Renderer.GetHtml());
        }
        
        [Test]
        public void RendersTwoComments()
        {
            Renderer.Comments = new [] { new Comment("Randy", "You did it"), new Comment("Bruce", "Nice code") };
            Assert.AreEqual("<strong>Randy</strong><p>You did it</p><br><strong>Bruce</strong><p>Nice code</p>", Renderer.GetHtml());
        }
    }
}