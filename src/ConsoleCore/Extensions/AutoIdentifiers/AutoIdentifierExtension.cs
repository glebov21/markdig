// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license.
// See the license.txt file in the project root for more information.

using System.Collections.Generic;
using System.IO;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace Markdig.Extensions.AutoIdentifiers
{
    /// <summary>
    /// The auto-identifier extension
    /// </summary>
    /// <seealso cref="IMarkdownExtension" />
    public class AutoIdentifierExtension : IMarkdownExtension
    {
        private const string AutoIdentifierKey = "AutoIdentifier";
        private readonly AutoIdentifierOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoIdentifierExtension"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public AutoIdentifierExtension(AutoIdentifierOptions options)
        {
            this.options = options;
        }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
        }
    }
}