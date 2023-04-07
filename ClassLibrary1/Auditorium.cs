﻿using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Auditorium //https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=share_link
    {
        public string Name { get; }
        public Worker Worker { get; }
        public byte Places { get; }
        public byte Window { get; }
        public List <Equipment> Equipment { get; }
        public Auditorium(string name, Worker worker, byte places, byte window, List <Equipment> equipment)
        {
            Name = name;
            Worker = worker;
            Places = places;
            Window = window;
            Equipment = equipment;
        }
    }
}