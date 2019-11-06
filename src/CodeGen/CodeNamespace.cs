using System;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace CodeGen
{
    class CodeNamespace: CodeBlock
    {
//        public new string Value { get; }
//        public new string Value { get => $"namespace ${Value}"; }
        public CodeNamespace(string value, StyleType style=StyleType.NewLine) : base(value, style) {}
        public new string Generate()  => $"namespace ${Value}";
    }
}
