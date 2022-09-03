
namespace MaxInno.NUWEE.Common.Menu
{
    public class ConsoleMenu
    {
        public string Title { get; init; } = "Menu";

        public IList<MenuEntry> Entries { get; } = new List<MenuEntry>();

        public void Loop()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n [ {0} ]\n", Title);

                var counter = 0;
                foreach (MenuEntry menuEntry in Entries)
                {
                    AddMenuEntry(ref counter, menuEntry.Title);
                }

                int exitEntryId = AddMenuEntry(ref counter, "Вихiд");

                Console.Write("\n Введiть ваш вибiр: ");
                string? rawUserChoice = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rawUserChoice) ||
                    !int.TryParse(rawUserChoice, out int parsedUserChoice))
                {
                    Console.WriteLine(" Неправильний ввiд. Повторiть спробу");
                    Console.ReadLine();
                    continue;
                }
                
                if (parsedUserChoice == exitEntryId)
                {
                    Console.WriteLine(" Вихiд з програми");
                    Environment.Exit(0);
                }

                MenuEntry entry = Entries[parsedUserChoice - 1];
                
                Console.Clear();
                Console.WriteLine("\n [ {0} ]\n", entry.Title);

                try
                {
                    entry.Executor();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("\n Помилка вводу: {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n Помилка: {0}", ex.Message);
                }

                Console.WriteLine("\n Програма закiнчила виконання");
                Console.WriteLine(" Натиснiть Enter для повернення до меню");
                Console.ReadLine();
            }
        }

        private static int AddMenuEntry(ref int id, string title)
        {
            id++;
            Console.WriteLine(" {0}) {1}", id, title);
            return id;
        }
    }
}