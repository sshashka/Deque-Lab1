namespace Deque
{
	public class Node<T>
	{
		public T Data { get; set; }
		public Node<T> Prev { get; set; }
		public Node<T> Next { get; set; }

		public Node(T data)
		{
			Data = data;
		}
		public Node()
		{ }

		// Function to get a new node
		static Node<T> GetNode(T data) => new Node<T>(data);

		public override string ToString()
		{
			return Data.ToString();
		}
	}
}
