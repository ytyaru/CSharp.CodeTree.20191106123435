using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // ReadOnlyCollection

namespace CodeGen
{
    class CodeTree
    {
        protected IList<INode> children;
        public IReadOnlyList<INode> Children { get; }
        public CodeTree()
        {
            children = new List<INode>();
            Children = new ReadOnlyCollection<INode>(children);
        }
        public CodeTree Add(INode node) { children.Add(node); return this; }
        public IReadOnlyList<INode> GetChildren() => Children;
    }
}
