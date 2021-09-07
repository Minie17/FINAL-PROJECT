using System;

namespace exception_demo_ticket
{
    class Ticket
    {
        static int Ticketavailable = 20;
        public void BuyTicket(int buynum)
        {
            Ticketavailable = buynum;
            if(buynum > Ticketavailable || Ticketavailable <0 )
            {
                throw (new TicketsFinishedException("Tickets are Over "));
            }
            Console.WriteLine("you Purched {0} tickets, Available tickets are {1}", buynum, Ticketavailable);
        }
     }
    public class TicketsFinishedException : exceptionticket
    {
        public TicketsFinishedException(string message): base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            int buynum;
            string response;
            try
            {
                do
                {
                    Console.WriteLine("Number of ticket you have to book:");
                    buynum = Convert.ToInt32(Console.ReadLine());
                    Ticket t = new Ticket();
                    t.BuyTicket(buynum);
                    Console.WriteLine("Are you willing to book more ticket:");
                    response = Console.ReadLine();
                }
                while (response == "y" || response == "n");
            }
            catch(TicketsFinishedException tf)
            {
                Console.WriteLine(tf.message);
            }
        }
    }
}
