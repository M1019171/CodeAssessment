//using SimpleInjector;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Patient.Demo.WebApp
//{
//    public class SimpleInjectorDependencyResolver : IDependencyResolver
//    {
//        public Container Container { get; private set; }

//        public SimpleInjectorDependencyResolver(Container container)
//        {
//            this.Container = container ?? throw new ArgumentNullException("container");
//        }


//        public object GetService(Type serviceType)
//        {
//            if (!serviceType.IsAbstract && typeof(IController).IsAssignableFrom(serviceType))
//            {
//                return this.Container.GetInstance(serviceType);
//            }
//            return ((IServiceProvider)this.Container).GetService(serviceType);
//        }

//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            return this.Container.GetAllInstances(serviceType);
//        }
//    }
//}