using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;
using Unity.Exceptions;

namespace IdiotBot.Api.App_Start
{
    public class UnityResolver : IDependencyResolver
    {
        #region Properties

        protected IUnityContainer _container;

        #endregion


        #region Constructor

        public UnityResolver(IUnityContainer container)
        {
            _container = container;
        }

        #endregion


        #region IDependencyResolver

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        #endregion
    }
}