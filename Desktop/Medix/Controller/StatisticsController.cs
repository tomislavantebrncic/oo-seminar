using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class StatisticsController : IStatisticsController
    {
        Statistics _statistics;

        public StatisticsController(Statistics statistics)
        {
            _statistics = statistics;
        }

        public void ViewStatistics(IStatisticsView inForm)
        {
            inForm.ShowModaless();
        }
    }
}
