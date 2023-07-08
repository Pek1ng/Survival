using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

public static class ClassDeclarationSyntaxExtensions
{
    public const char NESTED_CLASS_DELIMITER = '+';
    public const char NAMESPACE_CLASS_DELIMITER = '.';

    public static string GetNamespace(this ClassDeclarationSyntax source)
    {
        Contract.Requires(null != source);

        var items = new List<string>();
        var parent = source.Parent;
        while (parent.IsKind(SyntaxKind.ClassDeclaration))
        {
            var parentClass = parent as ClassDeclarationSyntax;
            Contract.Assert(null != parentClass);
            items.Add(parentClass.Identifier.Text);

            parent = parent.Parent;
        }

        var nameSpace = parent as NamespaceDeclarationSyntax;

        if (nameSpace == null)
        {
            return null;
        }

        var sb = new StringBuilder().Append(nameSpace.Name).Append(NAMESPACE_CLASS_DELIMITER);
        items.Reverse();
        items.ForEach(i => { sb.Append(i).Append(NESTED_CLASS_DELIMITER); });

        var result = sb.ToString().TrimEnd(NAMESPACE_CLASS_DELIMITER);
        return result;
    }

    public static string GetFullName(this ClassDeclarationSyntax source)
    {
        var result = GetNamespace(source);

        if (string.IsNullOrEmpty(result))
        {
            return source.Identifier.ValueText;
        }
        return result + NAMESPACE_CLASS_DELIMITER + source.Identifier.ValueText;
    }
}