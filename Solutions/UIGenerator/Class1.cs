using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleSourceGenerator
{
    [Generator]
    public class ExampleSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var allNodes = context.Compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
            var allClassDeclarations = allNodes.Where(cds => cds.IsKind(SyntaxKind.ClassDeclaration)).OfType<ClassDeclarationSyntax>();

            List<ClassDeclarationSyntax> classDeclarations = new List<ClassDeclarationSyntax>();

            foreach (var cds in allClassDeclarations)
            {
                var have = cds.AttributeLists.SelectMany(x => x.Attributes).All(attr => attr.Name.ToFullString() == "RuntimeInitializeOnLoadMethod");

                if (have)
                {
                    classDeclarations.Add(cds);
                }
            }


            var sourceBuilder = new StringBuilder(
            @"
            using System;
            namespace UISourceGenerated
            {
                public static class UISourceGenerated
                {
                    public static string GetTestText() 
                    {
                        return ""This is from source generator ");

            foreach (var item in classDeclarations)
            {
                sourceBuilder.Append(item.Identifier.ValueText);
                sourceBuilder.Append(";");
            }

            sourceBuilder.Append(
                @""";
                    }
    }
}
");

            context.AddSource("UISourceGenerator.gen.cs", SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext context) { }
    }
}