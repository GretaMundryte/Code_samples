using System;
using System.IO;

namespace HtmlGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var renderer = new CommentsRenderer();
            renderer.Comments = new[]
            {
                new Comment("Randy", "Great work"), 
                new Comment("Brown", "Keep it up"),
            };
            using var writer = File.CreateText("./test.html");
            writer.WriteLine(renderer.GetHtml());
        }
    }
}