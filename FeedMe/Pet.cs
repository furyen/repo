using System;

namespace FeedMe
{
    class Pet
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public DateTime BirthDate { get; set; }
        public int Id { get; set; }
        public int Weight {get;set;}
        public DateTime FeedTime { get; set; }
        public DateTime WalkTime { get; set; }

        public Pet(string name, string type, DateTime birthDate, int weight, DateTime feedTime, DateTime walkTime, int id)
        {
            Name = name;
            Type = type;
            BirthDate = birthDate;
            Weight = weight;
            FeedTime = feedTime;
            WalkTime = walkTime;
            Id = id;
        }

       
        public override string ToString()
        {
            return Name + " - " + Type;
        }

    }
}
