using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList<int> list = new LinkedList<int>();

            foreach (int num in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })
            {
				list.AddFirst(num);
            }

            /*foreach (int num in list)
            {
                Console.WriteLine(num);
            }*/

            LinkedListNode<int> importantNode = new LinkedListNode<int>(15);
            list.AddFirst(importantNode);

            for (LinkedListNode<int> nodo = list.First; nodo != null; nodo = nodo.Next)
            {
                int num = nodo.Value;
                Console.WriteLine(num);
            }
        }
	}
}