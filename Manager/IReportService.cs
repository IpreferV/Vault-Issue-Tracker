using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Manager;

namespace Manager.Services
{
    public interface IReportService
    {
        void AddReport(Report report);
        void DeleteReport(int id);
        IEnumerable<Report> GetAllReports();
        Report GetReportsById(int id);
        void UpdateReport(int id, Report report);
    }
}