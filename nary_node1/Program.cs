using nary_node1;

NaryNode<string> rootNode = new NaryNode<string>("Root");
NaryNode<string> aNode = new NaryNode<string>("A");
NaryNode<string> bNode = new NaryNode<string>("B");
NaryNode<string> cNode = new NaryNode<string>("C");
NaryNode<string> dNode = new NaryNode<string>("D");
NaryNode<string> eNode = new NaryNode<string>("E");
NaryNode<string> fNode = new NaryNode<string>("F");
NaryNode<string> gNode = new NaryNode<string>("G");
NaryNode<string> hNode = new NaryNode<string>("H");
NaryNode<string> iNode = new NaryNode<string>("I");

rootNode.AddChild(aNode);
rootNode.AddChild(bNode);
rootNode.AddChild(cNode);

aNode.AddChild(dNode);
aNode.AddChild(eNode);

cNode.AddChild(fNode);

dNode.AddChild(gNode);

fNode.AddChild(hNode);
fNode.AddChild(iNode);

Console.WriteLine(rootNode.ToString());
Console.WriteLine(aNode.ToString());
Console.WriteLine(bNode.ToString());
Console.WriteLine(cNode.ToString());
Console.WriteLine(dNode.ToString());
Console.WriteLine(eNode.ToString());
Console.WriteLine(fNode.ToString());
Console.WriteLine(gNode.ToString());
Console.WriteLine(hNode.ToString());
Console.WriteLine(iNode.ToString());