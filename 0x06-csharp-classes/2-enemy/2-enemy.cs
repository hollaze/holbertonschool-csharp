﻿using System;

namespace Enemies
{
    /// <summary>Zombie class.</summary>
    public class Zombie
    {
        /// <value>health of the zombie.</value>
        public int health;

        /// <summary>
        ///  Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>
        ///  Initializes a new instance of the <see cref="Zombie"/> class.
        /// <param name="value">health value.</param>
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
