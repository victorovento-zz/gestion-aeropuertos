using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{

    

    class ListaEnlazada<E> : ILista<E>
    {

        private int Size;
        private Node<E> first;
        private Node<E> last;

        private class Node<E>
            {
            public E data;
            public Node<E> next;
    
            public Node(E e)
            {
                data = e;
                next = null;
            }

        }
        public void add(E e)
        {
            Node<E> node = new Node<E>(e);
            if (first == null)
            {
                first = node;
            }
            else
            {
                Node<E> puntero = first;
                int c = 0;
                while (puntero.next != null)
                {
                    puntero = puntero.next;
                    c++;
                }
                node.next = puntero.next;
                puntero.next = node;

            }
        }

        public void Clear()
        {
            Node<E> next = null;
            for (Node<E> x = this.first; x!=null; x = next) {
                next = x.next;
                x.data = default(E);
                x.next = null;
            }
            this.first = this.last = null;
            this.Size = 0;
            ++this.Size;
        }

        public E get(int Index)
        {
            if (first == null)
            {
                return default(E);
            }
            else
            {
                Node<E> puntero = first;
                int contador = 0;
                while (contador<Index && puntero.next != null)
                {
                    puntero = puntero.next;
                    contador++;
                }
                if(contador!= Index)
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
            return first == null;
        }

        public int size()
        {
            return Size;
        }

        
    }
}
