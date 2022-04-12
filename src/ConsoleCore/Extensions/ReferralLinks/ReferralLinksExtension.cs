// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license.
// See the license.txt file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Markdig.Renderers;

namespace Markdig.Extensions.ReferralLinks
{
    public class ReferralLinksExtension : IMarkdownExtension
    {
        public ReferralLinksExtension(string[] rels)
        {
            Rels = rels?.ToList() ?? throw new ArgumentNullException(nameof(rels));
        }

        public List<string> Rels { get; }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
        }


    }
}
