using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class HeroRepository
    {
        //-- Fields
        private Hero _hero;

        public void CreateCharacter(string name)
        {
            _hero = new Hero
            {
                Name = name,
                IsAlive = true,
                Health = 3
            };
        }

        public Character CharacterDetails()
        {
            return _hero;
        }
        public void TakeDamage()
        {
            _hero.Health--;
        }
        public int GetHeroHealth()
        {
            return _hero.Health;
        }
    }
}
