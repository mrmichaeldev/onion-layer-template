using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace $ext_projectname$.Implementations
{
    using Interfaces;
    using Interfaces.Models;

    public class $ext_projectname$Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<$ext_projectname$>().As<I$ext_projectname$>();
        }
    }
}
