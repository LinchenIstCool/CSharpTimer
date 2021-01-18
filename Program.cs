using System;

namespace StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Console.Title = "Timer";
            //Process to check how long the user wants the timer to run
            Console.Write("How long do you want the timer to be(enter it in seconds): ");
            
            //Stores the time of the timer
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds/60;
            int hours = minutes/60;
            Console.WriteLine("\n");

            //Left Seconds and minutes
            
            
            //Waits until timer needs to be started
            Console.WriteLine("Press 'S' to start");

            //Initiates Timer
            if(Console.ReadKey(true).Key==ConsoleKey.S)
            {
                Console.WriteLine("\n");
                
                
                for (int i = -1; i < seconds; seconds--)
                {
                    if(seconds>3600)
                    {   
                        int leftOverMinutes = minutes%60;
                        int leftOverSeconds = seconds%60;

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hours + "h" + leftOverMinutes + "m" + leftOverSeconds + "s");
                        Console.Title = "Timer - " + hours + "h" + leftOverMinutes + "m" + leftOverSeconds + "s";
                    }
                    else if(seconds>60)
                    {
                        int leftOverSeconds = seconds%60;
                        
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(minutes + "m" + leftOverSeconds + "s");
                        Console.Title = "Timer - " + minutes + "m" + leftOverSeconds + "s";
                    }
                    else
                    {

                        System.Threading.Thread.Sleep(1000);
                        //Checks if the time is 6 or lower to signalise time is slowly running out
                        if(seconds<=9)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        //Checks if the time is 3 or lower to signalise time is nearly over
                        if(seconds<=3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine(seconds + "s");
                        Console.Title = "Timer - " + seconds + "s";
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            // Wait before closing
            Console.Write("\nPress 'E' to exit the process..."); 
  
            // here it asks to press "E" to exit 
            // and the key "E" is not shown in 
            // the console output window 
            while (Console.ReadKey(true).Key != ConsoleKey.E) { 
            } 
            */


            Console.Title = "Timer";
            //Process to check how long the user wants the timer to run
            Console.Write("How long do you want the timer to be(enter it in seconds): ");
            
            //Stores the time of the timer
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Left Seconds and minutes
            
            
            //Waits until timer needs to be started
            Console.WriteLine("Press 'S' to start");

            //Initiates Timer
            if(Console.ReadKey(true).Key==ConsoleKey.S)
            {
                Console.WriteLine("\n");
                
                
                for (int i = -1; i < seconds; seconds--)
                {
                    if(seconds>3600)
                    {   
                        int minutes = seconds/60;
                        int hours = minutes/60;

                        int leftOverMinutes = minutes%60;
                        int leftOverSeconds = seconds%60;

                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(hours + "h" + leftOverMinutes + "m" + leftOverSeconds + "s");
                        Console.Title = "Timer - " + hours + "h" + leftOverMinutes + "m" + leftOverSeconds + "s";
                    }
                    else if(seconds>60)
                    {
                        int minutes = seconds/60;

                        int leftOverSeconds = seconds%60;
                        
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(minutes + "m" + leftOverSeconds + "s");
                        Console.Title = "Timer - " + minutes + "m" + leftOverSeconds + "s";
                    }
                    else
                    {

                        System.Threading.Thread.Sleep(1000);
                        //Checks if the time is 6 or lower to signalise time is slowly running out
                        if(seconds<=9)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        //Checks if the time is 3 or lower to signalise time is nearly over
                        if(seconds<=3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine(seconds + "s");
                        Console.Title = "Timer - " + seconds + "s";
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            // Wait before closing
            Console.Write("\nPress 'E' to exit the process..."); 
  
            // here it asks to press "E" to exit 
            // and the key "E" is not shown in 
            // the console output window 
            while (Console.ReadKey(true).Key != ConsoleKey.E) { 
            }
        }
    }
}