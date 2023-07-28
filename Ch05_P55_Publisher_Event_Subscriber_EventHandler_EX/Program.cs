using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_P55_Publisher_Event_Subscriber_EventHandler_EX
{
    delegate void ChangeEventHandler(object sender, EventArgs e);
    internal class Subscriber
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            pub.Changed += PublisherChangedHandler;
            pub.IdNum = 10;
            pub.Score = 99;
            Console.Read();
        }
        static void PublisherChangedHandler(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString() +"\t" + e.ToString() + "\t" + ((Publisher)sender).IdNum + "\t" + ((Publisher)sender).Score);
        }
    }
    class Publisher 
    {
        private int idNum;
        private int score;
        public event ChangeEventHandler Changed;

        public int IdNum
        { 
            get => idNum;
            set 
            {
                idNum = value;
                if (Changed != null) Changed(this, EventArgs.Empty);
            }
        }
        public int Score
        {
            get => score;
            set
            {
                score = value;
                if(Changed != null) Changed(this, EventArgs.Empty);
            }
        }
    }
}
