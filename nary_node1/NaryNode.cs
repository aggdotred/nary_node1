namespace nary_node1
{
	public class NaryNode<T>
	{
		T Value;
		List<NaryNode<T>> Children;

		public NaryNode(T value)
		{
			Value = value;
			Children = new List<NaryNode<T>>();
		}

		public void AddChild(NaryNode<T> child)
		{
			Children.Add(child);
		}

		public override string ToString()
		{
			string output = $"{Value}:";
			foreach (NaryNode<T> child in Children) 
			{
				output += $" {child.Value}";
			}
			return output;
		}
	}
}
