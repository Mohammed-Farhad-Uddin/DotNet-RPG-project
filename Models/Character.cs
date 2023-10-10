using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_RPG.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        // public string? Name { get; set; } 
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intellige { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.knight;
        public User? User { get; set; }
        public Weapon? Weapon { get; set; }
        public List<Skill>? Skills { get; set; } 
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; } 
    }
}