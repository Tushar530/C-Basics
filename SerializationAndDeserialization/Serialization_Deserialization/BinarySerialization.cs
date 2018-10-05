using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class BinarySerialization
    {
        static List<Ticket> Ticket = new List<Ticket>();
        private static readonly IEnumerable<Ticket> TicketList;

        public static void AddTicket()
        {
            Ticket.Add(new Ticket() { PNR_NO = 4578, Source = "Chennai", Destination = "Jaipur", Type = "SLEEPEP", NoOfTickets = 4 });
            Ticket.Add(new Ticket() { PNR_NO = 4578, Source = "HYD", Destination = "Delhi", Type = "SLEEPEP", NoOfTickets =3});
            Ticket.Add(new Ticket() { PNR_NO = 4578, Source = "Vellore", Destination = "Mumbai", Type = "SLEEPEP", NoOfTickets = 2 });


              public static void SerializeTicket()
        {
            FileStream fileStreams = new FileStream("Ticket.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStreams, Ticket);
            fileStreams.Close();
        }

        /* public  void List<Ticket> Deserialization()
        {
            FileStream fs = new FileStream("Ticket.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Ticket> deserializeList = new List<Ticket>();
            deserializeList = (List<Ticket>)formatter.Deserialize(fs);
            return deserializeList; 
        }
        */

        static void Main(string[] args)
        {

            AddTicket();
            SerializeTicket();
           // List<Ticket> TicketList = Deserialization();
            Console.WriteLine( "List of student after deserialization:");
            foreach (Ticket ticket in TicketList)
            {
                Console.WriteLine(Ticket.PNR_NO);
                Console.WriteLine("-");
                Console.WriteLine(Ticket.Source);
            }
        }
    }

    [Serializable]
        public class Ticket
        {
            public int PNR_NO { get; set; }

            public string Source { get; set; }
        public string Destination { get; set; }
        public string Type { get; set; }
        public int NoOfTickets { get; set; }

    }

    
}
