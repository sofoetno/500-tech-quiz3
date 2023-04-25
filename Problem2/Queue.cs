// Შექმენით Custom Queue- ჯენერიკ იმპლემენტიაცია განუსაზღვრეთ კონსტრუქტორი პარამეტრიანი და უპარამეტროც.
// Უნდა შეიძებოდეს ქიუს ზომის შემოწმება ცარიელია თუ არა. Უნდა იყოს ელემენტის დამატების და წაშლის მეთოდები.
// Დანარჩენი მეთოდები შეგიძლიათ დაამატოთ სურვილისამებრ.

using System.Collections.Generic;

namespace Problem2
{
    public class Queue<T>
    {
        private LinkedList<T> _queue = new LinkedList<T>();

        public Queue()
        {
            
        }

        public int Size
        {
            get { return _queue.Count; }
        }

        public bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }

        public void Enqueue(T item)
        {
            _queue.AddFirst(item);
        }

        public T Dequeue()
        {
            LinkedListNode<T> first = _queue.First;
            _queue.RemoveFirst();
            return first.Value;
        }
    }
}