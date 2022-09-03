// See https://aka.ms/new-console-template for more information

using MaxInno.NUWEE.Common.Menu;
using MaxInno.NUWEE.Labs.N2;

var menu = new ConsoleMenu
{
    Title = "Лабораторна 2",
    Entries =
    {
        new MenuEntry
        {
            Title = "Task 1",
            Executor = Tasks.Task1
        },
        new MenuEntry
        {
            Title = "Task 2",
            Executor = Tasks.Task2
        },
        new MenuEntry
        {
            Title = "Task 3",
            Executor = Tasks.Task3
        },
        new MenuEntry
        {
            Title = "Task 4",
            Executor = Tasks.Task4
        },
        new MenuEntry
        {
            Title = "Task 5",
            Executor = Tasks.Task5
        }
    }
};

menu.Loop();