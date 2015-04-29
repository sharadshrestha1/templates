using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Template.Business
{
    public class ComponentContainer
    {
        private IUnityContainer _container;
        public IUnityContainer Container
        {
            get
            {
                if (_container == null)
                    _container = ComponentContainer.GetContainer();
                return _container;
            }
        }


		/// <summary>
		/// This method grabs unity information from Configuration
		/// </summary>
		/// <returns></returns>
        private static IUnityContainer GetContainer()
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
			section.Configure(container);
            return container;
        }
    }
}
