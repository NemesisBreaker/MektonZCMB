using System;
namespace MektonZCMB.Models
{
    public class Servo
    {
        public string ServoName { get; set; }
        public string ServoType { get; set; }
        public double ServoWeight { get; set; }
        public double ServoCost { get; set; }
        public int BaseServoKills { get; set; }
        public int BaseServoSpace { get; set; }
        public int CurrentServoKills { get; set; }
        public int CurrentServoSpace { get; set; }
        public int Thruster { get; set; }
        public int GES { get; set; }
        public Servo()
        {
        }
    }
}
