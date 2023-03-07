using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    public class MyQueue
    {
        int val = 0;
        MyQueue next = null, front = null, rear = null;
        public MyQueue() { }

        public void Push(int x)
        {
            MyQueue newNode = new MyQueue();
            newNode.val = x;
            newNode.next = null;

            if (front == null && rear == null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            rear.next = newNode;
            rear = newNode;
        }

        public int Pop()
        {
            int value = front.val;
            front = front.next;
            if (front == null) rear = null;
            return value;
        }

        public int Peek()
        {
            return front.val;
        }

        public bool Empty()
        {
            return front == null && rear == null;
        }
    }

    internal class P_232
    {

    }
}
