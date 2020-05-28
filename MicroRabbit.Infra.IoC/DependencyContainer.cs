using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
        }
            // Domain Bus
         //   services.AddTransient<IEventBus, RabbitMQBus>();
            // Domain Banking Commands
         //   services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            // Applicatio//n Services
          //  services.AddTransient<IAccountService, AccountService>();
          //  services.AddTransient<ITransferService, TransferService>();
            // Data
           // services.AddTransient<IAccountRepository, AccountRepository>();
          //  services.AddTransient<ITransferRepository, TransferRepository>();
           // services.AddTransient<BankingDbContext>();
           // services.AddTransient<TransferDbContext>();
        //}
    }
}
