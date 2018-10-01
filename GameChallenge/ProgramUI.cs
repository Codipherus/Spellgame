using System;

namespace GameChallenge
{
    class ProgramUI
    {
        private HeroRepository _heroRepo = new HeroRepository();
        private EnemyRepository _enemyRepo = new EnemyRepository();

        public void Run()
        {
            SetUpGame();
            RunGame();
            // EndGame();
        }

        private void SetUpGame()
        {
            CreateHero();
            CreateEnemy();
            ShowHeroDetails();
            ShowEnemyDetails();

        }

        private void CreateHero()
        {
            Console.WriteLine("What is thy name, wanderer?\n");
            string name = Console.ReadLine();
            _heroRepo.CreateCharacter(name);
        }

        private void CreateEnemy()
        {
            Console.WriteLine("What is the name of thy foe, wanderer?\n");
            string name = Console.ReadLine();
            _enemyRepo.CreateCharacter(name);
        }

        private void ShowHeroDetails()
        {
            var hero = _heroRepo.CharacterDetails();

            Console.WriteLine($" \n {hero.Name}'s  Health: {hero.Health} \n");
        }

        private void ShowEnemyDetails()
        {
            var enemy = _enemyRepo.CharacterDetails();

            Console.WriteLine($" \n {enemy.Name}'s  Health: {enemy.Health} \n");
        }

        private void RunGame()
        {
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            while (hero.IsAlive && enemy.IsAlive)
            {
                //DO STUFF
                PromptPlayer();
            }
        }

        private void PromptPlayer()
        {
            Console.WriteLine("What spell would you like to cast? \n" +
                "1. Fireball \n" +
                "2. Earth Smash \n" +
                "3. Flood");
            var userChoice = int.Parse(Console.ReadLine());



            Random r = new Random();
            int computerChoice = r.Next(1, 3);

            if (computerChoice == 1)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("The computer chose Fireball");
                    Console.WriteLine("DRAW");
                    //no change
                    //display current health of each
                    
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("The computer chose FireBall");
                    Console.WriteLine("Defeat! Fireball burns the Earth!");
                    // -1
                    _heroRepo.TakeDamage();
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("The computer chose Fireball");
                    Console.WriteLine("Victory! Flood douses Fireball!");
                    // +1
                    _enemyRepo.TakeDamage();
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat
                }
                else
                {
                    Console.WriteLine("You must choose Fireball, Flood, or Earth Smash!");

                }
            }



            else if (computerChoice == 2)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("The computer chose Earth Smash");
                    Console.WriteLine("Victory! Fireball burns Earth!");
                    _enemyRepo.TakeDamage();
                    //display current health of each  --DONE 
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat

                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("The computer chose Earth Smash");
                    Console.WriteLine("Sorry, you lose! Earth Smash soaks up the Flood!");
                    // -1
                    _heroRepo.TakeDamage();
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat

                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("The computer chose Earth Smash");
                    Console.WriteLine("DRAW");
                    //no change
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat
                }
                else
                {
                    Console.WriteLine("You must choose Fireball, Flood, or Earth Smash!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("The computer chose Flood");
                    Console.WriteLine("You Lose! Flood douses the Fireball!");
                    // -1
                    _heroRepo.TakeDamage();
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat

                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("The computer chose Flood");
                    Console.WriteLine("DRAW");
                    // no change
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat

                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("The computer chose Flood");
                    Console.WriteLine("You win! Earth Smash soaks up the Flood");
                    // +1
                   _enemyRepo.TakeDamage();
                    //display current health of each
                    //if both alive play again
                    //if enemy health zero = display victory
                    //if player health zero = display defeat

                }
                else
                {
                    Console.WriteLine("You must choose Fireball, Flood, or Earth Smash!");

                }

            }
            ShowHeroDetails();
            ShowEnemyDetails();
            //get health
            
            //if (_enemyRepo.GetEnemyHealth() == 0)
            //{
            //    Console.WriteLine("VICTORY! \n" +
            //        "Press Enter to see the victory screen!");
            //    //run endgame victory
            //    EndGameVictory();

            //}
            //else 
            //    if (_heroRepo.GetHeroHealth() == 0)
            //{
            //    Console.WriteLine("DEFEAT! \n" +
            //        "Press Enter to see the defeat screen...");
            //    //run endgame defeat
            //    EndGameDefeat();
            //    private void EndGameDefeat
            //}

            Console.ReadLine();



            //public void EndGame()
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}