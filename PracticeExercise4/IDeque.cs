using System;
namespace PracticeExercise4
{
    public interface IDeque<T>
    {
        void AddFront(T item);
        void AddBack(T item);

        T RemoveFront();
        T RemoveBack();

        bool IsEmpty { get; }
        int Length { get; }

        T Front { get; }
        T Back { get; }

    }
}
