using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wallet.Domain.Interfaces;
using Wallet.EndPoint.WinForm.Customers;
using Wallet.EndPoint.WinForm.Transaction;
using Wallet.Persistance.Common;
using Wallet.Persistance.Data;
using Wallet.Persistance.Repositories;

namespace Wallet.EndPoint.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var serviceProvider = new ServiceCollection()
                .AddTransient<frmMain>()
                .AddTransient<frmLogin>()
                .AddTransient<frmCustomers>()
                .AddTransient<frmAddOrEditCustomer>()
                .AddTransient<frmAddTransaction>()
                .AddTransient<frmReport>()
                // Add your forms or services here
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<WalletDbContext>()
                .AddDbContext<WalletDbContext>(options =>
                    options.UseSqlServer("DefaultConnection"))
                .BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<frmMain>();
            System.Windows.Forms.Application.Run(mainForm);

            //var frmCustomers = serviceProvider.GetRequiredService<frmCustomers>();

            //frmCustomers.Owner = mainForm;
            //frmCustomers.Show();

            //System.Windows.Forms.Application.Run(frmCustomers);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //System.Windows.Forms.Application.Run(new frmMain());
        }
    }
}