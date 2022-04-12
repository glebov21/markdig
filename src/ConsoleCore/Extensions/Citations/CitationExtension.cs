// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using System.Diagnostics;
using Markdig.Parsers.Inlines;
using Markdig.Renderers;
using Markdig.Syntax.Inlines;

namespace Markdig.Extensions.Citations
{
    /// <summary>
    /// Extension for cite ""...""
    /// </summary>
    /// <seealso cref="IMarkdownExtension" />
    public class CitationExtension : IMarkdownExtension
    {
        public void Setup(MarkdownPipelineBuilder pipeline)
        {
            var parser = pipeline.InlineParsers.FindExact<EmphasisInlineParser>();
            if (parser != null && !parser.HasEmphasisChar('"'))
            {
                parser.EmphasisDescriptors.Add(new EmphasisDescriptor('"', 2, 2, false));
            }
        }

        private static string? GetTag(EmphasisInline emphasisInline)
        {
            Debug.Assert(emphasisInline.DelimiterCount <= 2);
            return emphasisInline.DelimiterCount == 2 && emphasisInline.DelimiterChar == '"' ? "cite" : null;
        }
    }
}