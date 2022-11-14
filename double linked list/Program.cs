using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /* Node class represents the node of doubly linked list.
        * it consists of the information part and links to
        * its succeeding and preceeding
        * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the precceeding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;
        
        //constructor
        public DoubleLinkedList()
        {
            START = null;
        }
       
    }
}
