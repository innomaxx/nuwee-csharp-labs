
using MaxInno.NUWEE.Common.Menu;
using MaxInno.NUWEE.Labs.N9;

var menu = new ConsoleMenu
{
    Title = "Лабораторна №9 - Автомобiль",
    Entries =
    {
        new MenuEntry
        {
            Title = "Записати в файл",
            Executor = Tasks.WriteToFile
        },
        new MenuEntry
        {
            Title = "Прочитати з файлу",
            Executor = Tasks.ReadFromFile
        }
    }
};

menu.Loop();