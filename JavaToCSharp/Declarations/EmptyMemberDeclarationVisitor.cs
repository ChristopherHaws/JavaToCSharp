using System;
using com.github.javaparser.ast.body;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace JavaToCSharp.Declarations
{
    public class EmptyMemberDeclarationVisitor : BodyDeclarationVisitor<EmptyMemberDeclaration>
    {
        public override MemberDeclarationSyntax VisitForClass(ConversionContext context, ClassDeclarationSyntax classSyntax, EmptyMemberDeclaration declaration)
        {
            throw new NotImplementedException("Empty Member Declaration's have not been implemented yet.");
        }

        public override MemberDeclarationSyntax VisitForInterface(ConversionContext context, InterfaceDeclarationSyntax interfaceSyntax, EmptyMemberDeclaration declaration)
        {
            throw new InvalidOperationException("Initializers are not valid on interfaces.");
        }
    }
}