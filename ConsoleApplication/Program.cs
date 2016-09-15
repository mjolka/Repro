using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        RunAsync().GetAwaiter().GetResult();
    }

    static async Task RunAsync()
    {
        var x = await Foo.GetAsync();
    }
}
