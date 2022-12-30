using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Http;
using MovieProject.Business.Abstract;
using MovieProject.Business.Concrete;
using MovieProject.DataAccess.Abstract;
using MovieProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieManager>().As<IMovieService>().SingleInstance();//Movie Manager'in kodları yazılacak !
            builder.RegisterType<EfMovieDal>().As<IMovieDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();//User manager'in kodları yazılacak !
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()

                }).SingleInstance();
        }
    }
}

