using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class MyLinkList
    {
        private Node current;


        public Node Head
        {
            get;
            set;
        }
        
        public MyLinkList()
        {
            Head = null;
        }

        public void Add(string content)
        {
            Node node = new Node();
            node.Data = content;

            if(Head == null)
            {
                Head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public bool Delete(int position)
        {
            current = Head;

            if (position == 1)
            {
                Head = current.Next;
                current.Next = null;
                current = null;
                return true;
            }

            if (position > 1)
            {
                Node tempNode = Head;
                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
            return false;

        }



    }
}
