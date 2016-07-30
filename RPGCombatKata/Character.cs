namespace RPGCombatKata
{
    public class Character
    {
        private const int StartingHealth = 1000;
        private const int StartingLevel = 1;
        private const bool StartingAlive = true;

        private int _health;
        public int Health { get { return _health; } }
        private int _level;
        public int Level { get { return _level; } }
        public bool _alive;
        public bool Alive { get { return _alive; } }


        public Character()
        {
            _health = StartingHealth;
            _level = StartingLevel;
            _alive = StartingAlive;
        }

        public void TakeDamage(int damage)
        {
            damage = SanitizeDamage(damage);

            if (damage >= _health)
            {
                _health = 0;
                Die();
                return;
            }

            _health -= damage;            
        }

        private int SanitizeDamage(int damage)
        {
            if (damage < 0)
            {
                damage = damage * -1;
            }

            return damage;
        }

        private void Die()
        {
            _alive = false;
        }
    }
}
