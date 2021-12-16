using System;
using System.ComponentModel;
using Deque;

namespace CLI
{
	public static class Program
	{
		private static void Main(string[] args)
		{
			var dq = new Deque<int>();

			dq.OnItemAdded += delegate(object obj, CollectionChangeEventArgs args)
			{
				Console.WriteLine($"Item with type {((Node<int>)args.Element).Data.GetType()} " +
				                  $"and content {((Node<int>)args.Element).Data} added to deque");
			};
			dq.OnItemDeleted += delegate(object obj, CollectionChangeEventArgs args)
			{
				Console.WriteLine($"Item with type {((Node<int>)args.Element).Data.GetType()} " +
				                  $"and content {((Node<int>)args.Element).Data} has been deleted");
			};

			dq.InsertBack(5);
			dq.InsertBack(10);

			dq.InsertFront(20);
			dq.InsertFront(40);
			Console.WriteLine("Current Back: " + dq.GetBack());
			Console.WriteLine("Current Front: " + dq.GetFront());

			dq.DeleteFront();
			Console.WriteLine("Current Front: " + dq.GetFront());

			dq.DeleteBack();
			Console.WriteLine("Current Back: " + dq.GetBack());

			dq.Erase();
			dq.PrintAll();

			try
			{
				dq.DeleteFront();
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine("Error " + e.Message);
			}
		}
	}
}
