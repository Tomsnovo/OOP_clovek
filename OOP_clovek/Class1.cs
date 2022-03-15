using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_clovek
{
    public class Clovek
    {
        private int Skill;
        private int Stamina; 

        public string name { get; set; }
        public string surname { get; }
        public DateTime birth { get; }
        public int stamina { get => Stamina;  }
        public int health { get; set; }
        public int skill { get => Skill; }
       
        public Clovek()
        {
            name = "";
            surname = "";
            birth = DateTime.Now;
            Stamina = 100;
            health = 100;
            Skill = 0;
        }
        public void Aging()
        {
            Stamina -= 10;
            if(Stamina < 0)
            {
                Stamina = 0;
            }
            health += 2;
        }

        public void levelUp()
        {
            Skill += 20;
            Stamina += 10;
        }

     

    }
}
