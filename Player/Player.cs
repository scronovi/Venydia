namespace PlayerLib
{
    public class Player
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public bool Attack = false;
        public bool Dead = false;


		// Maybe put in separate class?
		public void Fight(Player player1, Player player2)
		{	
			while (!player1.Dead && !player2.Dead)
			// Needs to update damage on every iteration
			// Maybe put random number here?
			{
				if (player1.Attack && !player2.Dead)
				{
					player2.Health = player2.Health - player1.Damage;
					Console.WriteLine("Player 1 hits Player 2 for " + player1.Damage);
					Console.WriteLine("Player 2 health is now " + player2.Health);

					if (player2.Health <= 0)
					{
						player2.Dead = true;
						Console.WriteLine("Player 1 wins");
						player1.Attack = false;
					}
					player1.Attack = false;
					player2.Attack = true;

				}
				else if (player2.Attack && !player1.Dead)
				{
					player1.Health = player1.Health - player2.Damage;
					Console.WriteLine("Player 2 hits Player 1 for " + player2.Damage);
					Console.WriteLine("Player 1 health is now " + player1.Health);

					if (player1.Health <= 0)
					{
						player1.Dead = true;
						Console.WriteLine("Player 2 wins");
					}
					player1.Attack = true;
					player2.Attack = false;

				}
			}
			

		}

	}

}