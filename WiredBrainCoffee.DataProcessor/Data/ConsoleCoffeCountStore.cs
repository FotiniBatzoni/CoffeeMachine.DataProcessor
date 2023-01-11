using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Data
{
    public class ConsoleCoffeCountStore : ICoffeCountStore
    {
        public void Save(CoffeeCountItem item)
        {
            var line = $"{item.CoffeeType}:{item.count}";
            Console.WriteLine(line);
        }
    }
}
