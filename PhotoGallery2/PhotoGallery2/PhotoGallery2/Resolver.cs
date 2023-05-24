using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Autofac;
namespace PhotoGallery2
{
    

        public static class Resolver
        {
            private static IContainer container;

            public static void Initialize(IContainer container)
            {
                Resolver.container = container;
            }

            public static T Resolve<T>()
            {
                return container.Resolve<T>();
            }
        }
    }