using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
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

        //if (Directory.Exists(ConfigUtility.GenPath))
        //{
        //    Directory.Delete(ConfigUtility.GenPath,true);
        //}

        //Directory.CreateDirectory(ConfigUtility.GenPath);

        try
        {
            List<ClassDeclarationSyntax> classDeclarations = GetUIClassDeclarationSyntaxList(context);

            logBuilder.AppendLine($"[Count]{classDeclarations.Count}");

            foreach (var item in classDeclarations)
            {
                if (ConfigManager.ProjectPath == null)
                {
                    ConfigManager.ProjectPath = ConfigManager.FindProjectFolder(item.SyntaxTree.FilePath);
                }

                if (logBuilder.Length > 0) { }

                var @namespace = item.GetNamespace();
                StringBuilder classStringBuilder = new StringBuilder();

                logBuilder.AppendLine($"[item.SyntaxTree.FilePat]{item.SyntaxTree.FilePath}");

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
                string value = ConfigManager.Get(fullName, index.ToString());

                while (!string.IsNullOrEmpty(value))
                {
                    classStringBuilder.AppendLine($"[HideInInspector]");
                    classStringBuilder.AppendLine($"public GameObject {value};");
                    index++;
                    value = ConfigManager.Get(fullName, index.ToString());
                }

                classStringBuilder.AppendLine("}");

                //命名空间尾部括号
                if (!string.IsNullOrEmpty(@namespace))
                {
                    classStringBuilder.AppendLine("}");
                }

                string code = classStringBuilder.ToString();
                //File.WriteAllText(Path.Combine(ConfigUtility.GenPath, $"{item.Identifier.ValueText}.gen.txt"), code);
                SourceText sourceText = SourceText.From(code, Encoding.UTF8);

                context.AddSource($"{item.Identifier.ValueText}.gen.cs", sourceText);
            }
        }
        catch (Exception e)
        {
            logBuilder.AppendLine($"[Error]{e}");
        }

        logBuilder.AppendLine($"[ProjectPath]{ConfigManager.ProjectPath}");
        logBuilder.AppendLine($"[LogPath]{ConfigManager.Instance.LogPath}");
        logBuilder.AppendLine($"[ConfigPath]{ConfigManager.Instance.ConfigPath}");
        File.WriteAllText(ConfigManager.Instance.LogPath, logBuilder.ToString());
    }

    public void Initialize(GeneratorInitializationContext context) { }


    public static List<ClassDeclarationSyntax> GetUIClassDeclarationSyntaxList(GeneratorExecutionContext context)
    {
        var allNodes = context.Compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
        var allClassDeclarations = allNodes.Where(cds => cds.IsKind(SyntaxKind.ClassDeclaration)).OfType<ClassDeclarationSyntax>();

        List<ClassDeclarationSyntax> classDeclarations = new List<ClassDeclarationSyntax>();

        foreach (var cds in allClassDeclarations)
        {
            var have = cds?.BaseList?.Types.Any(attr => attr.ToString() == FLAG_NAME);

            if (have==null)
            {
                continue;
            }

            if ((bool)have)
            {
                classDeclarations.Add(cds);
            }
        }

        return classDeclarations;
    }
}