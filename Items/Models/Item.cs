using Nunu_s_Adventures.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunu_s_Adventures.Items.Models
{
    public class Item : IItem
    {
        public ItemType Name;
        public string Description;
        public int ObjectiveNumber;
        public int GoldValue;
    }
    public enum ItemType
    {
        Melee,
        Ranged,
        Torch,
        Rope,
        Food,
        Potions
    }
}
