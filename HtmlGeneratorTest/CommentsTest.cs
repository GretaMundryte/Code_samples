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
            Renderer.AuthorNames = new string [] {};
            Assert.AreEqual("", Renderer.GetHtml());
        }

        [Test]
        public void ReturnName1()
        {
            Renderer.AuthorNames = new string [] {"Randy"};
            Assert.AreEqual("<strong>Randy</strong>", Renderer.GetHtml());
        }

        [Test]
        public void ReturnName2()
        {
            Renderer.AuthorNames = new string [] {"Randy", "Bruce"};
            Assert.AreEqual("<strong>Randy</strong><br><strong>Bruce</strong>", Renderer.GetHtml());
        }
    }
}