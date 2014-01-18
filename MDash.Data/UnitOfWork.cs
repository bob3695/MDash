using MDash.Data.Contracts;
using System;

namespace MDash.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Private Variables

        private MDashContext context;

        private IPlexServerRepository plexServerRepository;

        #endregion Private Variables

        #region Public Properties

        public IPlexServerRepository PlexServerRepository
        {
            get
            {
                if (plexServerRepository == null)
                    plexServerRepository = new PlexServerRespository(context);

                return plexServerRepository;
            }
        }

        #endregion Public Properties

        #region Contstructor

        public UnitOfWork()
        {
            context = new MDashContext();
        }

        #endregion Contstructor

        #region Methods

        public void Save()
        {
            context.SaveChanges();
        }

        #endregion Methods

        #region IDisposable Methods

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Methods
    }
}