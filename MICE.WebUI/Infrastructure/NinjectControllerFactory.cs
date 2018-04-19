using MICE.Domain.Abstract;
using MICE.Domain.Concrete;
using MICE.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MICE.WebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            /* Mock<IUserRepository> mockUser = new Mock<IUserRepository>();
             mockUser.Setup(m => m.Users).Returns(new List<User>
             {
                 new User { ID=1, Login="Administrator", Password="123",Rules="Администратор"},
                 new User { ID=2, Login="Jeny828", Password="123",Rules="Модератор"},
                 new User { ID=3, Login="Artem12", Password="123",Rules="Модератор"},
                 new User { ID=4, Login="andrey778", Password="123",Rules="Пользователь"},
                 new User { ID=5, Login="evgeniy18", Password="123",Rules="Пользователь"}
             }.AsQueryable());

             ninjectKernel.Bind<IUserRepository>().ToConstant(mockUser.Object);*/

             ninjectKernel.Bind<IUserRepository>().To<EFUserRepository>();
             ninjectKernel.Bind<INewsRepository>().To<EFNewsRepository>();
        }
    }
}