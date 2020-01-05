using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{



    class ListaEnlazada<E> : ILista<E>
    {

        private int size;
        public Node<E> head = null;
        private Node<E> current;

        public ListaEnlazada()
        {
            head = null;
            size = 0;
            current = head;
        }

        public int Size { get => size; set => size = value; }

        public class Node<E>
        {
            public E data;
            public Node<E> next = null;

            public Node(E e)
            {
                data = e;
            }

        }
        public void add(E e)
        {
            Node<E> nodo = new Node<E>(e);
            if (head == null)
            {
                head = nodo;
            }
            else
            {
                Node<E> puntero = head;
                while (puntero.next != null)
                {
                    puntero = puntero.next;
                }
                puntero.next = nodo;
            }
            size++;
        }

        public void Clear()
        {
            Node<E> next = null;
            for (Node<E> x = this.head; x != null; x = next)
            {
                next = x.next;
                x.data = default(E);
                x.next = null;
            }
            this.head = null;
            this.size = 0;
            ++this.size;
        }

        public E get(int Index)
        {
            if (head == null)
            {
                return default(E);
            }
            else
            {
                Node<E> puntero = head;
                int contador = 0;
                while (contador < Index && puntero.next != null)
                {
                    puntero = puntero.next;
                    contador++;
                }
                if (contador != Index)
                {
                    return default(E);
                }
                else
                {
                    return puntero.data;
                }

            }
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public Node<Vuelo> SortedMerge(Node<Vuelo> a, Node<Vuelo> b)
        {
            Node<Vuelo> result = null;
            //Casos bases
            if (a == null) return b;
            if (b == null) return a;
            //Selecciona 1, a o b y hace recursión
            if (a.data.Precio <= b.data.Precio)
            {
                result = a;
                result.next = SortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = SortedMerge(a, b.next);
            }
            return result;
        }

        public Node<Vuelo> mergeSort(Node<Vuelo> h)
        {
            //Caso base: Si first es null
            if (h == null || h.next == null)
            {
                return h;
            }
            //Obtener el medio de la lista
            Node<Vuelo> middle = getMiddle(h);
            Node<Vuelo> nextofmiddle = middle.next;
            //Establece el nodo siguiente al del medio a null
            middle.next = null;
            //Aplica MergeSort a la lista izquierda
            Node<Vuelo> left = mergeSort(h);
            //Aplica Merge Sort a la derecha
            Node<Vuelo> right = mergeSort(nextofmiddle);
            //Mezcla las listas izquierda y derecha
            Node<Vuelo> sortedlist = SortedMerge(left, right);
            return sortedlist;
        }

        //Utilidad para obtener
        //el medio de la LinkedLIst

        Node<Vuelo> getMiddle(Node<Vuelo> h)
        {
            //Caso base
            if (h == null) return h;
            Node<Vuelo> fastptr = h.next;
            Node<Vuelo> slowptr = h;

            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;

        }

    }
}
