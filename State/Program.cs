namespace State
{
    internal class Program
    {
        static void Main()
        {
            CandyMachine candyMachine = new(5);
            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();

            Console.WriteLine($"Осталось конфет: {candyMachine.CandyLeft}");
        }
    }
}