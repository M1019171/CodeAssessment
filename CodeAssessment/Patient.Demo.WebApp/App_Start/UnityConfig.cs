using Patient.Demo.BusinessLayer;
using Patient.Demo.DataLayer;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Patient.Demo.WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPatientDemoBusinessLayer, PatientDemoBusinessLayer>();
            container.RegisterType<IPatientDemoDataAccessLayer, PatientDemoDataAccessLayer>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}