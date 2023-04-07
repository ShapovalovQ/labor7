using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Auditorium //https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=share_link
    {
        public string Name { get; }
        public Worker Worker { get; }
        public uint Places { get; }
        public uint Window { get; }
        public List<Equipment> Equipment { get; }
        public Auditorium(string name, Worker worker, uint places, uint window, List<Equipment> equipment)
        {
            this.Name = name;
            this.Worker = worker;
            this.Places = places;
            this.Window = window;
            this.Equipment = equipment;
        }
    }
}