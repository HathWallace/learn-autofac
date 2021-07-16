using Autofac;
using ConsoleApplication.Dao;
using ConsoleApplication.Logic;
using ConsoleApplication.Service;

namespace ConsoleApplication.AutoFac
{
    /// <summary>
    /// 容器注册类
    /// </summary>
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register your own things directly with Autofac, like:
            builder.RegisterType<DaoImpl>()
                .As<IDao>()
                .InstancePerDependency()
                .AsImplementedInterfaces();
            builder.RegisterType<ServiceImpl>()
                .As<IService>()
                .InstancePerDependency()
                .AsImplementedInterfaces();
            builder.RegisterType<LogicImpl>()
                .As<ILogic>()
                .InstancePerDependency()
                .AsImplementedInterfaces();

            // 获取所有控制器类型并使用属性注入
            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .PropertiesAutowired(new AutowiredPropertySelector());
        }
    }
}