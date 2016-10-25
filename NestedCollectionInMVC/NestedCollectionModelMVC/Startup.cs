using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NestedCollectionModelMVC.Startup))]
namespace NestedCollectionModelMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
