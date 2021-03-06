﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IRepository<T, id>
    {
        T GetById(id objectToGet);
        List<T> GetAll();
        IQueryable<T> FilterGetAll();
        void Delete(int id);
        void Delete(T objectToDelete);
        T Add(T objectToAdd);
        T Update(T objectToUpdate);
    }
}
