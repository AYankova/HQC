namespace MementoPattern
{
    using System.Collections.Generic;

    internal class Caretaker<T>
    {
        // list of states saved
        private static readonly List<Memento<T>> Mementos = new List<Memento<T>>();

        // save state of the originator
        public static void SaveState(Originator<T> origintor)
        {
            Mementos.Add(origintor.CreateMemento());
        }

        // restore state of the originator
        public static void RestoreState(Originator<T> originator, int stateNumber)
        {
            originator.SetMemento(Mementos[stateNumber]);
        }
    }
}
