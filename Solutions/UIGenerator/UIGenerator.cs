using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[Generator]
public class UIGenerator : ISourceGenerator
{
    public const string FLAG_NAME = "View";

    public void Execute(GeneratorExecutionContext context)
    {
        StringBuilder logBuilder = new StringBuilder();

        if (!Directory.Exists(ConfigUtility.GenPath))
        {
            Directory.CreateDirectory(ConfigUtility.GenPath);
        }

        logBuilder.AppendLine($@"[ConfigPath]{ConfigUtility.ConfigPath}");

        try
        {
            var classDeclarations = GetUIClassDeclarationSyntaxList(context);

            logBuilder.AppendLine($"[Count]{classDeclarations.Count}");

            foreach (var item in classDeclarations)
            {
                var @namespace = item.GetNamespace();
                StringBuilder classStringBuilder = new StringBuilder();

                //引用
                classStringBuilder.AppendLine("using UnityEngine;");

                //命名空间
                if (!string.IsNullOrEmpty(@namespace))
                {
                    classStringBuilder.AppendLine($"namespace {@namespace} {{");
                }

                //类
                classStringBuilder.AppendLine($"public partial class {item.Identifier.ValueText} {{");

                int index = 0;
                string fullName = item.GetFullName();
                string value = ConfigUtility.Get(fullName, index.ToString());

                while (!string.IsNullOrEmpty(value))
                {
                    classStringBuilder.AppendLine($"[HideInInspector]");
                    classStringBuilder.AppendLine($"public GameObject {value};");
                    index++;
                    value = ConfigUtility.Get(fullName, index.ToString());
                }

                classStringBuilder.AppendLine("}");

                //命名空间尾部括号
                if (!string.IsNullOrEmpty(@namespace))
                {
                    classStringBuilder.AppendLine("}");
                }

                string code = classStringBuilder.ToString();
                File.WriteAllText(Path.Combine(ConfigUtility.GenPath, $"{item.Identifier.ValueText}.gen.txt"), code);
                SourceText sourceText = SourceText.From(code, Encoding.UTF8);

                context.AddSource($"{item.Identifier.ValueText}.gen.cs", sourceText);
            }
        }
        catch (System.Exception e)
        {
            logBuilder.AppendLine($"[Error]{e}");
        }

        File.WriteAllText(ConfigUtility.LogPath, logBuilder.ToString());
    }

    public void Initialize(GeneratorInitializationContext context) { }


    public static List<ClassDeclarationSyntax> GetUIClassDeclarationSyntaxList(GeneratorExecutionContext context)
    {
        var allNodes = context.Compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
        var allClassDeclarations = allNodes.Where(cds => cds.IsKind(SyntaxKind.ClassDeclaration)).OfType<ClassDeclarationSyntax>();

        List<ClassDeclarationSyntax> classDeclarations = new List<ClassDeclarationSyntax>();

        foreach (var cds in allClassDeclarations)
        {
            var have = cds.BaseList.Types.Any(attr => attr.ToString() == FLAG_NAME);

            if (have)
            {
                classDeclarations.Add(cds);
            }
        }

        return classDeclarations;
    }
}