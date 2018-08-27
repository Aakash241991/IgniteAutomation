using System;



    class Program
    {
    

        static void Main()
        {}
            
            public double length;
            public double width;

        public double GetArea()
        {
            return length * width;

        }
        public void display()
        {
            Console.WriteLine("Length : {0}",length);
            Console.WriteLine("width : {0}",width);
            Console.WriteLine("area : {0}", GetArea());
        }
    }
       

                // int? TicketsOnsale = null;

                // int AvailableTickets = TicketsOnsale ?? 0 ;

                //if (TicketsOnsale ==null)
                //{
                //    AvailableTickets = 0;
                //}
                //else
                //{
                //    AvailableTickets = TicketsOnsale.Value;
                //}
                //Console.WriteLine("Available tickets " + AvailableTickets);

                //Console.WriteLine("Available tickets {0}", AvailableTickets);

                //bool? AreYouMajor = false;

                //if(AreYouMajor == true)
                //{
                //    Console.WriteLine("User is Major");
                //}
                //else if(AreYouMajor == false)
                //{
                //    Console.WriteLine("User is not a Major");
                //}
                //else
                //{
                //    Console.WriteLine("User did not select any option");
                //}

                //int Number = 110;

                //bool IsNumber10 = Number ==10 ? true : false ;

                //bool IsNumber10;

                //if(Number == 10)
                //{
                //    IsNumber10 = true;
                //}
                //else
                //{
                //    IsNumber10 = false;

                //}

                //Console.WriteLine("Number == 10 is {0}", IsNumber10);

                //int Numerator = 10;

                //int Denoominator = 2;

                //int Result = Numerator / Denoominator;

                //int Result2 = Numerator % Denoominator;

                //Console.WriteLine("Result = {0} and {1}", Result, Result2);

                //Console.WriteLine("Result =" + Result + Result2);

                //int i = 0;

                //Console.WriteLine("Total int max value is"+ int.MaxValue);

                //bool a = true;

                //Console.WriteLine("Correct  " + bool.TrueString);

                //Console.WriteLine("Please enter your FirstName");

                //string FirstName = Console.ReadLine();

                //Console.WriteLine("Please enter your LastName");

                //string LastName = Console.ReadLine();

                //string FirstName = "aakash";
                // string LastName = "deolekar";

                // Console.WriteLine("Hello, " + FirstName + " "+ LastName+".");



                //Console.WriteLine("Hello, {0} {1}.", FirstName , LastName);

                Console.Read();
    
            }
}

            
    }

