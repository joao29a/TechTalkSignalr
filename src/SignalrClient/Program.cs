using System;
using System.Threading.Tasks;

namespace SignalrClient
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var port = Convert.ToInt32(args[0]);

            Console.WriteLine("Escriba su nombre: ");
            var user = Console.ReadLine();

            var client = new Client(port, user);

            await client.Start();

            Console.WriteLine("¡En línea!");

            while (true)
            {
                var message = Console.ReadLine();
                
                await client.SendMessage(message);
            }
        }
    }
}
