using Microsoft.Extensions.DependencyInjection;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels.Abstract;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.Applications.Desktop.AdminPanel.Configuration;

public static class MvvmServiceCollectionExtension
{
    public static void RegisterViews(this ServiceCollection services)
    {

        services.AddScoped<LoginWindow>();
    }

    public static void RegisterViewModels(this ServiceCollection services)
    {
        services.AddScoped<ILoginViewModal, LoginNewViewModel>();
    }

}
