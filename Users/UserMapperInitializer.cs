using System;
using AutoMapper;

namespace Users
{
    public class UserMapperInitializer
    {
        public static void Initialize(Action<IMapperConfigurationExpression> config = null)
        {
            Mapper.Initialize(cfg => { 
                cfg.AddProfile<UserMappingConfiguration>();
                config?.Invoke(cfg);
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}