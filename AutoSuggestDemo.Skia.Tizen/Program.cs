using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace AutoSuggestDemo.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new AutoSuggestDemo.App(), args);
            host.Run();
        }
    }
}
