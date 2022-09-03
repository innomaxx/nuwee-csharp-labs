
using MaxInno.NUWEE.Common.Menu;
using MaxInno.NUWEE.Labs.N4;

var menu = new ConsoleMenu
{
    Title = "Лабораторна 4 - Автомобiль",
    Entries =
    {
        new MenuEntry
        {
            Title = "Завдання 1",
            Executor = Tasks.Task1
        },
        new MenuEntry
        {
            Title = "Завдання 2",
            Executor = Tasks.Task2
        }
    }
};

menu.Loop();