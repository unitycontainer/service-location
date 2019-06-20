using CommonServiceLocator;
using Microsoft.Practices.Unity.ServiceLocation.Tests.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Unity.Lifetime;
using Unity.ServiceLocation;

namespace ServiceLocation.Tests
{
    [TestClass]
    public class GitHubIssuesFixture
    {
        [TestMethod]
        public void Issue_5()
        {
            var container = new UnityContainer();
            container.RegisterType<SimpleLogger>(new ContainerControlledLifetimeManager());
            
            var locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
            
            var logger = ServiceLocator.Current.GetInstance<SimpleLogger>();

            Assert.IsNotNull(logger);
            Assert.IsInstanceOfType(logger, typeof(SimpleLogger));
        }
    }
}
