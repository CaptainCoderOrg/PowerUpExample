using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    public interface IPowerup
    {
        /// <summary>Attempts to have the specified GameObject collect the powerup.</summary>
        /// <returns>Returns true if the powerup was picked up and false otherwise</returns>
        public bool TryCollect(GameObject character);
    }
}