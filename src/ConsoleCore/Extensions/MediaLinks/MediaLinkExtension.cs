// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license.
// See the license.txt file in the project root for more information.

using System;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax.Inlines;

namespace Markdig.Extensions.MediaLinks
{
    /// <summary>
    /// Extension for extending image Markdown links in case a video or an audio file is linked and output proper link.
    /// </summary>
    /// <seealso cref="IMarkdownExtension" />
    public class MediaLinkExtension : IMarkdownExtension
    {
        public MediaLinkExtension() : this(new MediaOptions())
        {
        }

        public MediaLinkExtension(MediaOptions? options)
        {
            Options = options ?? new MediaOptions();
        }

        public MediaOptions Options { get; }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
        }

        private static HtmlAttributes GetHtmlAttributes(LinkInline linkInline)
        {
            var htmlAttributes = new HtmlAttributes();
            var fromAttributes = linkInline.TryGetAttributes();
            if (fromAttributes != null)
            {
                fromAttributes.CopyTo(htmlAttributes, false, false);
            }

            return htmlAttributes;
        }
    }
}
