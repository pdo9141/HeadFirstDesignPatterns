using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var towerMediator = new CommunicationTower();

            var airCraft1 = new AirCraft(towerMediator) { Name = "Unit #1" };
            var airCraft2 = new AirCraft(towerMediator) { Name = "Unit #2" };
            var airCraft3 = new AirCraft(towerMediator) { Name = "Unit #3" };
            var airCraft4 = new AirCraft(towerMediator) { Name = "Unit #4" };
            var airCraft5 = new AirCraft(towerMediator) { Name = "Unit #5" };

            towerMediator.Send(airCraft1, "Let's go up!");

            Console.ReadLine();
        }
    }

    public abstract class Mediator
    {
        public IList<AirCraft> AirCrafts { get; private set; }

        public Mediator()
        {
            AirCrafts = new List<AirCraft>();
        }

        public abstract void Send(AirCraft sender, string message);
    }

    public class CommunicationTower : Mediator
    {
        public override void Send(AirCraft sender, string message)
        {
            foreach (var airCraft in AirCrafts)
            {
                if (airCraft != sender)
                {
                    airCraft.Receive(sender, message);
                }
            }
        }
    }

    public abstract class AirCraftCollegue
    {
        public abstract void Receive(AirCraft sender, string message);
    }

    public class AirCraft : AirCraftCollegue
    {
        public AirCraft(CommunicationTower mediator)
        {
            mediator.AirCrafts.Add(this);
        }

        public string Name { get; set; }

        public override void Receive(AirCraft sender, string message)
        {
            Console.WriteLine("{0}: Received message '{1}' from '{2}'", Name, message, sender.Name);
        }
    }
}
