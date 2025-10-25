using System.Threading.Tasks;

namespace FundoBase.ConsoleApp
{
    public class AppExecutor
    {
        public AppExecutor()
        {
            // Aqui você pode injetar serviços da camada Service, Infra, etc.
        }

        public Task RunAsync()
        {
            Console.WriteLine("ConsoleApp FundoBase iniciado com suporte a DI.");
            return Task.CompletedTask;
        }
    }
}
