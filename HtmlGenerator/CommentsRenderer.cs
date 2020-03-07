using System;

namespace HtmlGenerator
{
    public class CommentsRenderer
    {
        public string[] AuthorNames;

        public string GetHtml()
        {
            string html = "";
            for (var i = 0; i < AuthorNames.Length; i++)
            {
                var needsComma = i > 0;
                if (needsComma)
                {
                    html = html + ", " + AuthorNames[i];
                }
                else
                {
                    html += AuthorNames[i];
                }
            }
            return html;
        }
    }
}