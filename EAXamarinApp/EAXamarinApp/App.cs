using EAXamarinApp.Helpers;
using EAXamarinApp.Interfaces;
using EAXamarinApp.Services;
using EAXamarinApp.Model;

namespace EAXamarinApp
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}