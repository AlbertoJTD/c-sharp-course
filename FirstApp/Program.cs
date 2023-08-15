using System;
using System.Security.Cryptography;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	class WarehouseObjects
	{
		private Object[] data;
		private int counter = 0;

        public WarehouseObjects(int numberElements)
        {
			data = new Object[numberElements];
        }

		public void AddElement(Object obj)
		{
			data[counter++] = obj;
			counter++;
		}

		public Object GetElement(int position)
		{
			return data[position];
		}
    }
}