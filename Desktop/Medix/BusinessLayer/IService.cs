﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IService<T, id>
    {
        T GetById(id objectToGet);
        List<T> GetAll();
        void Delete(T objectToDelete);
        T Add(T objectToAdd);
        T Update(T objectToUpdate);
    }
}
