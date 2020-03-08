using System;

namespace HtmlGenerator
{
    public class CommentsRenderer
    {
        public Comment[] Comments = {};

        public string GetHtml()
        {
            string html = "";
            for (var i = 0; i < Comments.Length; i++)
            {
                var needsComma = i > 0;
                if (needsComma)
                {
                    html = html + "<br>";
                }
                html += "<strong>" + Comments[i].AuthorName + "</strong><p>" + Comments[i].Text + "</p>";
            }
            return html;
        }
    }

    public class Comment
    {
        public string AuthorName;
        public string Text;

        public Comment(string name, string text)
        {
            AuthorName = name;
            Text = text;
        }
    }
}