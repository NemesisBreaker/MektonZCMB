using System;
namespace MektonZCMB.Models
{
    public class Weapon
    {

        public int CP { get; set; }
        public string Name { get; set; }
        public int Space { get; set; }
        public int Kills { get; set; }
        public double Weight { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }
        public int Type { get; set; }
        public int Shots { get; set; }
        public int BurstValue { get; set; }
        public int WeaponAccuracy { get; set; }
        public int DefenseAccuracy { get; set; }
        public int StoppingPower { get; set; }
        public string Notes { get; set; }
        public Weapon()
        {
        }
    }
}
