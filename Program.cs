using System;

namespace GraphTraversals {
    class Program {
        static void Main(string[] args) {

            //initializing a tree
            Node root = new Node(null, "A");
            Tree graph = new Tree(root);
            Node two = new Node(root, "B");
            Node three = new Node(root, "C");
            Node four = new Node(root, "D");

            Node five = new Node(two, "E");
            Node six = new Node(three, "F");
            Node seven = new Node(three, "G");

            Node eight = new Node(six, "H");
            Node nine = new Node(four, "I");
            Node ten = new Node(four, "J");

            Node result = graph.GetNodeByDFS(new Node(null, "z"));
            var nodeValue = (result == null) ? "No node found" : result.Value;
            Console.WriteLine("Node Value:" + nodeValue);


            string path = "No value";
            if (result != null) {
                path = result.Value;
                var parentNode = result.Parent;
                while (parentNode != null) {
                    path = parentNode.Value + " > " + path;
                    parentNode = parentNode.Parent;
                }
            }

            Console.WriteLine("Path to node:" + path);
            Console.ReadKey();
        }
    }
}
