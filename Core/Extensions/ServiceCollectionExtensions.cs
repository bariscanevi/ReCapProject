using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    //extensions olması için static olması gerek
    // burada polymorphism yapıcaz
    //IServiceCollection araya girmesini istediğimiz servisleri eklediğimiz yerdir apimizizn servis bağımlılklarını eklediğimiz koleksiyondur
    //bubrda yaptıkarlımız core katmanı dahil bütün injecitonalrı tuttuğumuz yer
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)//genişletmek istediğimizi this ile veriyoruz 
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);//servisleri burada create ediyoruz
        }
    }
}
