using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        // 1. Create a static method in a static class
        // 2. The first parameter has to be the type to which we are adding the extension method
        // 3. return type should be IHtmlString, as these strings are excluded from encoding
        // 4. To help, creation of HTML tags, use TagBuilder class
        // 5. Include the namespace of the helper method in either the view or web.config

        // Image extension method
        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tb.Attributes.Add("alt", alt);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

        /*
        public static string Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tb.Attributes.Add("alt", alt);
            return (tb.ToString(TagRenderMode.SelfClosing));
        }
        */
    }
}