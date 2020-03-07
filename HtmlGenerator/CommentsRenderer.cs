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
                    html = html + "<br>" + "<strong>" + Comments[i].AuthorName + "</strong>";
                }
                else
                {
                    html += "<strong>" + Comments[i].AuthorName + "</strong>";
                }
            }
            return html;
        }
    }

    public class Comment
    {
        public string AuthorName;

        public Comment(string name)
        {
            AuthorName = name;
        }
    }
}