using System;

namespace DesignPatternsLibrary.Adapter.DuckAdapter
{
    public class DuckTestDrive : IDesignPattern
    {
		public void RunExample()
		{
			IDuck duck = new MallardDuck();

			ITurkey turkey = new WildTurkey();
			IDuck turkeyAdapter = new TurkeyAdapter(turkey);

			Console.WriteLine("The Turkey says...");
			turkey.Gobble();
			turkey.Fly();

			Console.WriteLine("\nThe Duck says...");
			TestDuck(duck);

			Console.WriteLine("\nThe TurkeyAdapter says...");
			TestDuck(turkeyAdapter);
		}

		private void TestDuck(IDuck duck)
		{
			duck.Quack();
			duck.Fly();
		}
	}
}
