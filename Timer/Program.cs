using System;
using System.Timers;

namespace TimerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello In Timer Program!");
            Console.WriteLine("set number of seconds to pass");
            string input = Console.ReadLine();
            int parsed;

            bool parsedSucces = int.TryParse( input, out parsed);

            /*  Create instance of Timer Class */

            Timer timer1 = new Timer();

            /*  Set Interval*/

            timer1.Interval = 1000;


            /*  Set what should happen on this event within arrow function ❤️ */

            int counter = 0;

            timer1.Elapsed += (sender, e) => { 

                if (counter < parsed)
                {
                    MyElapsedMethod(sender, e, counter);
                    counter++; 
                   
                }
                else
                {
                    Console.WriteLine("To quit press q.");
                    timer1.Stop();
                }

            };
          
            timer1.Enabled = true;

            while (Console.Read() != 'q');
        }
        private static void MyElapsedMethod(object sender, EventArgs e,int counter)
        {
          
            Console.WriteLine($"{counter+1} second");

        }
       
    }
}
