using System;
namespace Legend.Domain.Interface
{
    public interface IRepositoryWrapper
    {
        IAccountRepository Account { get; }
        ICharacterRepository Character { get; }
        void Save();

    }
}

