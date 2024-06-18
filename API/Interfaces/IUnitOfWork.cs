using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;

namespace API.Entities
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }

        ILikesRepository LikesRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}