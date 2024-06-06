using UnityEngine;
namespace CaptainCoder.PowerUpExample
{
    public class ManaPowerup : StatPowerup<ManaComponent>
    {
        public ManaPowerup(int bonus) : base(bonus) { } 

        public override void ApplyBonus(ManaComponent character) => character.Mana += Bonus;
    }
}