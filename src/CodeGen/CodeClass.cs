using System;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace CodeGen
{
    class CodeClass: CodeBlock
    {
//        public new string Value { get => $"class ${Value}"; }
        public CodeClass(string value, StyleType style=StyleType.NewLine) : base(value, style) {}
        public new string Generate()  => $"class ${Value}";
    }
}
