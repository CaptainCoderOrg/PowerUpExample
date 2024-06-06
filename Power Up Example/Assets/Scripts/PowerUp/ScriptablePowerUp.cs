using System;
using System.Linq;
using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    [CreateAssetMenu(fileName = "Powerup", menuName = "Powerup Example")]
    public class ScriptablePowerup : ScriptableObject, IPowerup
    {
        public PowerUpEntry[] Bonuses;
        public bool TryCollect(GameObject character)
        {
            bool wasCollected = false;
            foreach (PowerUpEntry powerups in Bonuses)
            {
                wasCollected |= powerups.TryCollect(character);
            }
            return wasCollected;
        }
    }

    [Serializable]
    public class PowerUpEntry
    {
        public StatOption Stat;
        public int Bonus;
        public IPowerup Powerup => Stat switch
        {
            StatOption.Health => new HealthPowerup(Bonus),
            StatOption.Mana => new ManaPowerup(Bonus),
            var option => throw new ArgumentException($"Unexpected stat {option}"),
        };

        public bool TryCollect(GameObject character)
        {
            return Powerup.TryCollect(character);
        }
    }

    public enum StatOption
    {
        Health,
        Mana,
    }
}