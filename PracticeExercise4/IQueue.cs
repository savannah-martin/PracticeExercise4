using System;
namespace PracticeExercise4
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();

        T First { get; }
        T Last { get; }

        bool IsEmpty { get; }
        int Length { get; }

    }
}
