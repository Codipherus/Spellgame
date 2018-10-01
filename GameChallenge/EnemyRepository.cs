using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    class EnemyRepository
    {
        private Enemy _enemy;


        public void CreateCharacter(string name)
        {
            _enemy = new Enemy
            {
                Name = name,
                Health = 3,
                IsAlive = true
            };
            
        }

        public int GetEnemyHealth()
        {
            return _enemy.Health;
        }

        public Character CharacterDetails()
        {
            return _enemy;
        }

        public void TakeDamage()
        {
            _enemy.Health --;
        }

    }
}
