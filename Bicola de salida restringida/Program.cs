using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bicola_de_salida_restringida.Program;

namespace Bicola_de_salida_restringida
{
    internal class Program
    {
        class OutputRestrictedDeque<T>
        {
            private LinkedList<T> deque = new LinkedList<T>();

            public void AddFront(T item)
            {
                deque.AddFirst(item);
            }

            public T RemoveRear()
            {
                if (deque.Count == 0)
                {
                    return default(T);
                }

                T item = deque.Last.Value;
                deque.RemoveLast();
                return item;
            }

            public T RemoveFront()
            {
                if (deque.Count == 0)
                {
                    return default(T);
                }

                T item = deque.First.Value;
                deque.RemoveFirst();
                return item;
            }

            public int Count()
            {
                return deque.Count;
            }
        }



        static void Main(string[] args)
        {
            OutputRestrictedDeque<int> deque = new OutputRestrictedDeque<int>();

            deque.AddFront(1);
            deque.AddFront(2);
            deque.AddFront(3);

            Console.WriteLine("Rear Element removed: " + deque.RemoveRear());
            Console.WriteLine("Front Element removed " + deque.RemoveFront());

            // No puedes agregar en el frente en esta implementación

            Console.WriteLine("Number of elements in the deque: " + deque.Count());

            Console.ReadKey();
        }
    
    }
}
