﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace FGD.Data.Service
{
    public interface ISharedFileRepository<TModel, TKey> : IRepository<TModel, TKey>
    {
        Task<ICollection<TModel>> GetAllByUserIdAsync(TKey userId);
    }
}
