using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    public class WorldItem : MonoBehaviour
    {
        public PowerUp PowerUp;
        public void OnTriggerEnter2D(Collider2D other)
        {
            // If the powerup was collected, destroy it
            if (PowerUp.TryCollect(other.gameObject))
            {
                Destroy(gameObject);
            }
        }
    }
}