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
        public void Test1()
        {
            Assert.AreEqual("", Renderer.GetHtml());
        }
    }
}