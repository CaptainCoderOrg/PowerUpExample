using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    public class HealthPowerup : StatPowerup<HealthComponent>
    {
        public HealthPowerup(int bonus) : base(bonus) {}
        public override void ApplyBonus(HealthComponent character) => character.Health += Bonus;
    }
}