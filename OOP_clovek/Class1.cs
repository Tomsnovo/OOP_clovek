using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_clovek
{
    public class Clovek
    {
        private int Skill;
        private int Stamina; 

        public string name { get; }
        public string surname { get; }
        public DateTime birth { get; }
        public int stamina { get => Stamina;  }
        public int health { get; set; }
        public int skill { get => Skill; }
       
        public Clovek(string name, string surname, DateTime birth, int stamina, int health, int skill)
        {
            name = "";
            surname = "";
            birth = DateTime.Now;
            stamina = 100;
            health = 100;
            skill = 0;
        }

        public void levelUp()
        {
            Skill += 20;
            Stamina += 10;
        }

     

    }
}
