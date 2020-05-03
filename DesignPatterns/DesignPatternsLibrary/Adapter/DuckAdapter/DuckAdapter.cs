using System;

namespace DesignPatternsLibrary.Adapter.DuckAdapter
{
    public class DuckAdapter : ITurkey
    {
		private readonly IDuck duck;
		private readonly Random rand;

		public DuckAdapter(IDuck duck)
		{
			this.duck = duck;
			rand = new Random();
		}

		public void Gobble()
		{
			duck.Quack();
		}

		public void Fly()
		{
			if (rand.Next(5) == 0)
			{
				duck.Fly();
			}
		}
	}
}
