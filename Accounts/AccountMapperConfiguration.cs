using System;
using Accounts.Dto;
using Accounts.Entities;
using AutoMapper;

namespace Accounts
{
    internal class AccountMapperConfiguration : Profile
    {
        public AccountMapperConfiguration()
        {
            CreateMap<AccountType, AccountTypeDto>()
                .ConstructUsing(MapAccountType);

            CreateMap<AccountTypeDto, AccountType>()
                .ConstructUsing(MapAccountTypeDto);
            
            CreateMap<Account, AccountDto>()
                .ReverseMap();
        }

        static AccountType MapAccountTypeDto(AccountTypeDto type)
        {
            switch (type)
            {
                case AccountTypeDto.Savings:
                    return AccountType.Savings;
                case AccountTypeDto.Current:
                    return AccountType.Current;
                default:
                    throw new NotSupportedException("Employee type is not support.");
            }
        }

        static AccountTypeDto MapAccountType(AccountType type)
        {
            switch (type)
            {
                case AccountType.Savings:
                    return AccountTypeDto.Savings;
                case AccountType.Current:
                    return AccountTypeDto.Current;
                default:
                    throw new NotSupportedException("Employee type is not support.");
            }
        }
    }
}