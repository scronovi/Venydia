using Weapons;

namespace PlayerLib
{
    public class Player
	{
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; } 
		public bool isTurn = false;
        public bool Dead = false;
		public string currentWeapon = "";

		public void Roll(Player player1, Player player2) 
		{
			// Get a value between 1 and 100 
			// Compare to other player
			// Higher value means that player starts
			// set attack to true
		}
		public void Fight(Player player1, Player player2)
		{
			// Reference
			Gun testGun = new Gun();
			Bow testBow = new Bow();

			while (!player1.Dead && !player2.Dead)
			{
				if (player1.isTurn && !player2.Dead)
				{
					if (player1.currentWeapon == "Gun")
					{
						player2.Health = player2.Health - (testGun.damageAttack());

						Console.WriteLine("Player 1 hits Player 2 for " + testGun.damageAttack());
						Console.WriteLine("Player 2 health is now " + player2.Health);

					}else if (player1.currentWeapon == "Bow")
					{
						player2.Health = player2.Health - (testBow.damageAttack());

						Console.WriteLine("Player 1 hits Player 2 for " + testBow.damageAttack());
						Console.WriteLine("Player 2 health is now " + player2.Health);
					}

					if (player2.Health <= 0)
					{
						player2.Dead = true;
						Console.WriteLine("Player 1 wins");
						player1.isTurn = false;
					}
					player1.isTurn = false;
					player2.isTurn = true;

				}
				else if (player2.isTurn && !player1.Dead)
				{
					// replace with function

					if (player2.currentWeapon == "Gun")
					{
						player1.Health = player1.Health - (testGun.damageAttack());

						Console.WriteLine("Player 2 hits Player 1 for " + testGun.damageAttack());
						Console.WriteLine("Player 1 health is now " + player1.Health);

					}
					else if (player2.currentWeapon == "Bow")
					{
						player1.Health = player1.Health - (testBow.damageAttack());

						Console.WriteLine("Player 2 hits Player 1 for " + testBow.damageAttack());
						Console.WriteLine("Player 1 health is now " + player1.Health);
					}

					if (player1.Health <= 0)
					{
						player1.Dead = true;
						Console.WriteLine("Player 2 wins");
					}
					player1.isTurn = true;
					player2.isTurn = false;
				}
			}
			

		}
	}

}