using NUnit.Framework;
using Shouldly;
using RPGCombatKata;

namespace RPGCombatKataTests
{
    public class CharacterWhenCreatedShould
    {
        [Test]
        public void HaveHealthAt1000()
        {
            var character = new Character();
            character.Health.ShouldBe(1000);
        }

        [Test]
        public void HaveLevelAt1()
        {
            var character = new Character();
            character.Level.ShouldBe(1);
        }

        [Test]
        public void BeAlive()
        {
            var character = new Character();
            character.Alive.ShouldBe(true);
        }
    }
}
