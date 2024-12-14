using System.Collections.Generic;
using Model;

namespace Manager.Services
{
    public class ReportService : IReportService
    {
        private readonly List<Report> _reports = new List<Report>();

        public void AddReport(Report report)
        {
            _reports.Add(report);
        }

        public void DeleteReport(int id)
        {
            var report = _reports.FirstOrDefault(r => r.id == id);
            if (report != null)
            {
                _reports.Remove(report);
            }
        }

        public IEnumerable<Report> GetAllReports()
        {
            return _reports;
        }

        public Report GetReportsById(int id)
        {
            return _reports.FirstOrDefault(r => r.id == id);
        }

        public void UpdateReport(int id, Report report)
        {
            var existingReport = _reports.FirstOrDefault(r => r.id == id);
            if (existingReport != null)
            {
                existingReport.id = report.id;
                existingReport.reportTitle = report.reportTitle;
                existingReport.reportDescription = report.reportDescription;
                existingReport.priority = report.priority;
                existingReport.status = report.status;
                existingReport.notes = report.notes;
            }
        }
    }
}