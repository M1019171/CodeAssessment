using Patient.Demo.BusinessLayer;
using Patient.Demo.DataLayer;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Routing;

namespace Patient.Demo.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var container = new Container();
            container.Register<IPatientDemoBusinessLayer, PatientDemoBusinessLayer>();
            container.Register<IPatientDemoDataAccessLayer, PatientDemoDataAccessLayer>();
            container.Verify();

          

            
        }
    }
}
