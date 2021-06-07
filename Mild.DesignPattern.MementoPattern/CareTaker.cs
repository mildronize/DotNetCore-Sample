using System.Collections.Generic;

namespace Mild.DesignPattern.MementoPattern
{
    public class CareTaker<T>
    {
        private readonly IList<Memento<T>> _histories;
        private int lastIndex;
        public CareTaker()
        {
            _histories = new List<Memento<T>>();
            lastIndex = -1;
        }

        public void PushMemento(Memento<T> memento)
        {
            for (int i = lastIndex + 1; i < _histories.Count; i++)
            {
                _histories.RemoveAt(i);
            }
            _histories.Add(memento);
            lastIndex += 1;
        }

        public Memento<T> Undo()
        {
            return _histories[lastIndex--];
        }

        public Memento<T> Redo()
        {
            return _histories[++lastIndex];
        }
    }
}