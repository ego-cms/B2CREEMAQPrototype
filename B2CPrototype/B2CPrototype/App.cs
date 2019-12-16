using B2CPrototype.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace B2CPrototype
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<MainViewModel>();
        }
    }
}