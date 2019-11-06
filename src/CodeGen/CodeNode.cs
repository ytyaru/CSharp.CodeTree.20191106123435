using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // ReadOnlyCollection

namespace CodeGen
{
    class CodeNode : INode
    {
        protected string Value { get; }
//        public string Value { get; }
//        public CodeNode(string value) : base() => Value = value;
        protected IList<INode> children { get; set; }
        protected IReadOnlyList<INode> Children { get; }
        public CodeNode(string value)
        {
            children = new List<INode>();
            Children = new ReadOnlyCollection<INode>(children);
            Value = value;
        }
//        public CodeNode(string value) : base() => this.value = value;
//        public CodeNode Add(CodeNode node) { children.Add(node); return this; }
//        public INode Add(CodeNode node) { children.Add(node); return this; }
        public IReadOnlyList<INode> GetChildren() => Children;
        public INode Add(INode node) { children.Add(node); return this; }
        public string Generate() => Value;
    }
}
