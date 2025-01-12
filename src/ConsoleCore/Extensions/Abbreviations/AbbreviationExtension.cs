// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

namespace Markdig.Extensions.Abbreviations
{
    /// <summary>
    /// Extension to allow abbreviations.
    /// </summary>
    /// <seealso cref="IMarkdownExtension" />
    public class AbbreviationExtension : IMarkdownExtension
    {
        public void Setup(MarkdownPipelineBuilder pipeline)
        {
            pipeline.BlockParsers.AddIfNotAlready<AbbreviationParser>();
        }
    }
}