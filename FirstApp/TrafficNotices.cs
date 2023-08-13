using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
	class TrafficNotices : INotice
	{
		// Properties
		private string sender;
		private string message;
		private string date;

		// Constructors
        public TrafficNotices()
        {
			this.sender = "Joe Doe";
			this.message = "you have a traffic infraction";
			this.date = "";
        }

        public TrafficNotices(string sender, string message, string date)
        {
			this.sender = sender;
			this.message = message;
			this.date = date;
        }

		// Interface methods
        public string GetDate()
		{
			return date;
		}

		public void ShowNotice()
		{
            Console.WriteLine("Sender: {0}\nMessage: {1}\nDate: {2}", sender, message, date);
        }
	}
}
