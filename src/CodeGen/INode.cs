using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // ReadOnlyCollection

namespace CodeGen
{
    interface INode
    {
//        protected IList<INode> children;
//        IList<INode> children { get; set; }
//        IReadOnlyList<INode> Children { get; }
//        public string Value { get; }
        /*
        public CodeTree()
        {
            children = new List<INode>();
            Children = new ReadOnlyCollection<INode>(children);
        }
        INode Add(INode node) { children.Add(node); return this; }
        */
        IReadOnlyList<INode> GetChildren();
        INode Add(INode node);
        string Generate();
    }
}
