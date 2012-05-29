using System.Web;
using System.Web.Mvc;

namespace Loopc.ProjectTracker.IOC
{
    public class InjectionHttpApplication : HttpApplication
    {
        public override void Init()
        {
            ControllerBuilder.Current.SetControllerFactory(new InjectionControllerFactory(new InjectionRepository().Kernel));
        }
    }
}
