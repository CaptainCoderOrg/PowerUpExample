using System;
using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    public abstract class StatPowerup<T> : IPowerup
    {
        public StatPowerup(int bonus) => Bonus = bonus;
        public int Bonus { get; set; }
        public bool TryCollect(GameObject character)
        {
            if (character.GetComponent<T>() is T component)
            {
                ApplyBonus(component);
                return true;
            }
            return false;
        }

        public abstract void ApplyBonus(T component);
    }
}