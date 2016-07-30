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
    }
}
