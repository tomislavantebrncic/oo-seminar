﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IMedicalFindingRepository
    {
        void SaveFinding(MedicalFinding finding);
    }
}
