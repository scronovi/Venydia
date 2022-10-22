namespace Weapons
{
	public class WeaponTemplate
{
		/* 
		 *NEEDED FIELDS*
		A weapon has a dmg field which sets minDmg and maxDmg
		A weapon has a crit chance
		A weapon has an attack function
		*/
		public int minDmg;
		public int maxDmg;
		public int dmg;

		// Returns the damage in an attack
		public int damageAttack()
		{
			Random rnd = new Random();
			this.dmg = rnd.Next(minDmg, maxDmg);
			return this.dmg;
		}
	}
	public class Gun : WeaponTemplate
    {
		public Gun() {
			this.maxDmg = 30;
			this.minDmg = 15;
		}
    }
    public class Bow : WeaponTemplate
    {
		public Bow()
		{
			this.maxDmg = 25;
			this.minDmg = 20;
		}
    }
}