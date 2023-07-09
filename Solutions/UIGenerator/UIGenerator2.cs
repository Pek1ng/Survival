using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Text;


[Generator]
public class UIGenerator2 : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        var sourceBuilder = new StringBuilder(
@"
            using System;
                public static class SourceGenerated
                {
                    public static string GetTestText() 
                    {
                        return ""This message from source  generator:");
        sourceBuilder.Append(DateTime.Now);

        sourceBuilder.Append(
            @""";
                    }
    }
");

        context.AddSource("exampleSourceGenerator", SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext context) { }
}