using BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW;

namespace Controller
{
    public abstract class BaseController
    {
        protected IUnitOfWork _unitOfWork { get; set; }

        public BaseController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void Close()
        {
            _unitOfWork.Commit();
            _unitOfWork = new UnitOfWork();
        }
    }
}
