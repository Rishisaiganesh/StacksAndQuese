using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQuese
{
    public class QuesNode
    {
        public int data;
        public QuesNode next;
    }
    public class Queue
    {
        public QuesNode top;
        public Queue()
        {
            this.top = null;
        }
        public bool IsEmpty()
        {
            if (this.top == null)
            {
                return true;
            }
            else
                return false;
        }
        public void Insertingqueue(int data)
        {
            QuesNode qNode = new QuesNode();
            qNode.data = data;
            if (IsEmpty() == true)
            {
                this.top = qNode;
                qNode.next = null;
            }
            else
            {
                QuesNode qNode1 = top;
                while (qNode1.next != null)
                {
                    qNode1 = qNode1.next;
                }
                qNode1.next = qNode;
            }
            Console.WriteLine("elements are" + qNode.data);
        }
        public void Display()
        {
            QuesNode qNode = this.top;
            if (IsEmpty() == true)
            {
                Console.WriteLine("the Queue is empty");
            }
            while (qNode != null)
            {
                Console.WriteLine(qNode.data);
                qNode = qNode.next;
            }
        }

    }
}
