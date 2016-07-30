using NUnit.Framework;
using Shouldly;
using RPGCombatKata;

namespace RPGCombatKataTests
{
    public class CharacterWhenTakenDamageShould
    {
        [Test]
        public void SubtractDamageFromHealth()
        {
            int damage = 10;
            var attackedCharacter = new Character();

            attackedCharacter.TakeDamage(damage);

            attackedCharacter.Health.ShouldBe(990);
        }

        [Test]
        public void HaveZeroHealthWhenDamageExceedsCurrentHealth()
        {
            int damage = 1001;
            var attackedCharacter = new Character();

            attackedCharacter.TakeDamage(damage);

            attackedCharacter.Health.ShouldBe(0);
        }

        [Test]
        public void DieWhenDamageExceedsCurrentHealth()
        {
            int damage = 1001;
            var attackedCharacter = new Character();

            attackedCharacter.TakeDamage(damage);

            attackedCharacter.Alive.ShouldBeFalse();
        }

        [Test]
        public void DieWhenHealthReachesZero()
        {
            int damage = 1000;
            var attackedCharacter = new Character();

            attackedCharacter.TakeDamage(damage);

            attackedCharacter.Alive.ShouldBeFalse();
        }
    }
}
