using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_clovek
{
    public class Clovek
    {
        public string name { get; }
        public string surname { get; }
        public DateTime birth { get; }
        int stamina { get; set; }
        int health { get; set; }
        int skill { get; set; }
       
        public Clovek(string name, string surname, DateTime birth, int stamina, int health, int skill)
        {
            this.name = name;
            this.surname = surname;
            this.birth = birth;
            this.stamina = stamina;
            this.health = health;
            this.skill = skill;
        }

     

    }
}
