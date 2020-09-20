using Microsoft.VisualBasic;
using Nunu_s_Adventures.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunu_s_Adventures.Entities.Models
{
    public class Character
    {
        public string Name;
        public int Level;
        public Abilities Abilities;
        public int Gold;
        public int InventoryWeight;
        public List<string> AdventuresPlayed;
        public bool IsAlive;
        public List<IItem> Inventory;
        public int HitPoints;
        public string Description;
    }
    public class Abilities
    {
        public int Strenght;
        public int Dexterity;
        public int Intelligence;
        public int Wisdow;
        public int Charisma;
    }
}
