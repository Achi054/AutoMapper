using System;
using AutoMapper;
using Users;

namespace Accounts
{
    public abstract class AccountMapperInitializer
    {   
        public static void Initialize()
        {
            UserMapperInitializer.Initialize(cfg => cfg.AddProfile<AccountMapperConfiguration>());
            Mapper.AssertConfigurationIsValid();            
        }
    }    
}