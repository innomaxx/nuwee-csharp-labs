
namespace MaxInno.NUWEE.Common.Menu
{
    public class MenuEntry
    {
        public string Title { get; init; }
        
        public Action Executor { get; init; }
    }
}