using System;

namespace Enemies
{
    /// <summary>Zombie class.</summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary>
        ///  Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="Zombie"/> class.
        /// <param name="value">zombie's health value.</param>
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>Get or Set the name.</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>Get zombie health.</summary>
        /// <returns>Return zombie health.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
