using System;
namespace Legend.API.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAccountRepository Account { get; }
        ICharacterRepository Character { get; }
        void Save();

    }
}

