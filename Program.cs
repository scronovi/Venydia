﻿using PlayerLib;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Weapons;

class Program
{
	static void Main()
	{

		// init player1 obj
		Player player1 = new();

		player1.Health = 100;

		player1.currentWeapon = "Bow";

		// init player2 obj
		Player player2 = new();

		player2.Health = 100;

		player2.currentWeapon = "Gun";








		// Roll a dice 1-100
		player1.Roll(player1, player2);
		// Fight
		player1.Fight(player1, player2);
		
	}
}