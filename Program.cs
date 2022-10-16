using PlayerLib;
using System.Runtime.CompilerServices;
using Weapons;

class Program
{
	static void Main()
	{
		// init random
		Random rnd = new Random();
		// init weapons
		Gun gun = new();
		gun.gunDamage = rnd.Next(55, 100);
		Bow bow = new();
		bow.bowDamage = rnd.Next(70, 87);
		

		// init player1 obj
		Player player1 = new();

		player1.Health = 100;

		// Random value depending on what weapon player1 uses
		player1.Damage = gun.gunDamage;

		// init player2 obj
		Player player2 = new();

		player2.Health = 100;

		// Random value depending on what weapon player2 uses
		player2.Damage = bow.bowDamage;

		// Roll a dice 1-100
		// if player 1 rolls higher then attack == true


		player1.Attack = true;
		// Fight
		player1.Fight(player1, player2);

	}
}