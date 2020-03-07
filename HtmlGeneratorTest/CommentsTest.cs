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
        public void ReturnName1()
        {
            Renderer.Comments = new[] { new Comment("Randy") };
            Assert.AreEqual("<strong>Randy</strong>", Renderer.GetHtml());
        }

        [Test]
        public void ReturnName2()
        {
            Renderer.Comments = new [] { new Comment("Randy"), new Comment("Bruce") };
            Assert.AreEqual("<strong>Randy</strong><br><strong>Bruce</strong>", Renderer.GetHtml());
        }
    }
}