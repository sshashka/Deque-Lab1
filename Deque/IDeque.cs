namespace Deque
{
	public interface IDeque<T>
	{
		void InsertFront(T data);
		void InsertBack(T data);
		void DeleteFront();
		void DeleteBack();
		T GetFront();
		T GetBack();
		bool IsEmpty();
		void Erase();
	}
}
