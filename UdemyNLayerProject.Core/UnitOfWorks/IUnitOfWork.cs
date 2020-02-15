using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Core.UnitOfWorks
{
    internal interface IUnitOfWork
    {
        IProductRepository Products { get; }

        ICategoryRepository categories { get; }

        Task CommitAsync();

        void Commit();
    }
}