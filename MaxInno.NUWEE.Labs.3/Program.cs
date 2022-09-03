
using MaxInno.NUWEE.Common.Menu;
using MaxInno.NUWEE.Labs.N3;

var menu = new ConsoleMenu
{
    Title = "Лабораторна 3",
    Entries =
    {
        new MenuEntry
        {
            Title = "Додавання",
            Executor = Tasks.Addition
        },
        new MenuEntry
        {
            Title = "Вiднiмання",
            Executor = Tasks.Subtraction
        },
        new MenuEntry
        {
            Title = "Множення",
            Executor = Tasks.Multiplication
        },
        new MenuEntry
        {
            Title = "Дiлення",
            Executor = Tasks.Division
        },
        new MenuEntry
        {
            Title = "Пiднесення до степеня",
            Executor = Tasks.Power
        }
    }
};

menu.Loop();