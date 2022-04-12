using Markdig.Extensions.SelfPipeline;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Syntax;

namespace Markdig
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Start");
            var markdown = @"# H1
**bbb**

> blockquote

[title](https://www.example.com)

| Syntax | Description |
| --- | --- |
| Header | Title |
| Paragraph | Text |";


            var pipeline = new MarkdownPipelineBuilder().Configure("pipetables+emphasisextras").Build();
            var doc = Markdown.Parse(markdown, pipeline);
            Console.WriteLine("Done");
        }
    }
}





