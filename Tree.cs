using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversals {
    public class Tree {

        public Node root;

        public Tree(Node rootNode) {
            this.root = rootNode;
        }

        public Node GetNodeByDFS(Node searchNode) {
            Stack<Node> nodeStack = new Stack<Node>();
            var node = root;
            nodeStack.Push(node);

            do {
                node = nodeStack.Peek();
                if (!node.isVisited) {
                    if(node.Value == searchNode.Value) {
                        return node;
                    }
                    node.isVisited = true;

                }

                var unvisitedNodes = node.Children?.Where(x => !x.isVisited);
                if (unvisitedNodes == null || !unvisitedNodes.Any()) {
                    nodeStack.Pop();
                }
                else {
                    nodeStack.Push(unvisitedNodes.First());
                }
            }
            while (nodeStack.Any());

            return null;
        }
    }
}
