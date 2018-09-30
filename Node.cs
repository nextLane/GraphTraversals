using System.Collections.Generic;
using System.Linq;

namespace GraphTraversals {
    public class Node {
        public Node Parent { get; set; }
        public string Value { get; set; }
        public List<Node> Children { get; set; }

        public bool isVisited = false;
        public Node(Node parent, string val) {
            this.Parent = parent;
            if (parent != null) {
                this.Parent.Children.Add(this);
            }
            this.Value = val;
            this.Children = new List<Node>();
        }

        public void SetChildren(IEnumerable<Node> childNodes) {
            this.Children = childNodes.ToList();
        }
    }
}
