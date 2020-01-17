using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Infrastructure
{
    public class TypeBroker
    {
        private static Type type = typeof(MemoryRepository);
        private static IRepostitory repostitory;
        public static IRepostitory Repostitory => repostitory ?? Activator.CreateInstance(type) as IRepostitory;
        public static void SetRepositoryType<T>() where T : IRepostitory => type = typeof(T);
        public static void SetTestObject(IRepostitory repo) 
        {
            repostitory = repo;
        }
    }
}
