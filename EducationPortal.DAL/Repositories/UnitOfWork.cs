﻿using System.Threading.Tasks;
using EducationPortal.DAL.DbContexts;
using EducationPortal.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EducationPortal.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EducationPortalContext context;

        public UnitOfWork(EducationPortalContext context) => this.context = context;

        public IRepository<T> Repository<T>() where T : class, IEntity
        {
            // return Startup.ConfigureServices().GetRequiredService<IRepository<T>>();
            return new Repository<T>(this.context);
        }

        public async Task<int> Commit() => await this.context.SaveChangesAsync();

        public void Dispose() => this.context.Dispose();
    }
}
