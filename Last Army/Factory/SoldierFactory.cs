using Last_Army.Entities.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Last_Army.Core
{
    public class SoldiersFactory
    {
        public SoldiersFactory()
        {
        }
        //name, age, experience, speed, endurance, motivation, maxWeight
        public static Soldier GenerateRanker(string name, int age, int experience, double endurance)
        {
            return new Ranker(name, age, experience,  endurance);
        }

        public static Soldier GenerateCorporal(string name, int age, int experience, double speed, double endurance,
            double motivation, double maxWeight)
        {
            return new Corporal(name, age, experience,endurance);
        }

        public static Soldier GenerateSpecialForce(string name, int age, int experience, double endurance)
        {
            return new SpecialForce(name, age, experience, endurance);
        }
    }
}