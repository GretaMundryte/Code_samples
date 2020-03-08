using System;
using System.IO;

namespace HtmlGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var renderer = new CommentsRenderer();
            renderer.Comments = new[] {new Comment("Randy"), new Comment("Brown"),};
            using (var writer = File.CreateText("C:\\Users\\greta\\Downloads\\Test.html"))
            {
                writer.WriteLine(renderer.GetHtml());
            }
        }
    }
}