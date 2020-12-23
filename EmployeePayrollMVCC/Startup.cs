using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeePayrollMVCC.Startup))]
namespace EmployeePayrollMVCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
