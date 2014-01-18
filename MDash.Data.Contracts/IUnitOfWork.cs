using System;

namespace MDash.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPlexServerRepository PlexServerRepository { get; }

        void Save();
    }
}