using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread input = new Thread(new ThreadStart(Controller.keyPressedEvent));
            Thread update = new Thread(new ThreadStart(stuff));
            input.Start();
            update.Start();
            input.Join();
            update.Join();
       
            Console.SetWindowSize(100, 30);


           

          

            
       
            Console.ReadLine();
        }


        public static void stuff() {

            Update.drawRect(2, 10, 0, 0);
        }
    }
}
