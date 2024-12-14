using Manager.Services;
using Model;

namespace Manager.Managers
{
    public class Manager : IReportService
    {
        // Temp Data
        private readonly List<Report> _reports = new List<Report>
        {
            new Report { id = 0, reportTitle = "Lorem Ipsum", reportDescription = "Dolor", priority = "High", status = "Open", notes = "Testing"}
        };

        // Function to display the list of reports
        public IEnumerable<Report> GetAllReports()
        {
            return _reports;
        }

        // Function to display the details of the report if there is a matching id
        public Report GetReportsById(int id) => _reports.FirstOrDefault(r => r.id == id);

        // Function that displays adds a reports to the list
        public void AddReport(Report report)
        {
            report.id = _reports.Max(r => r.id) + 1;
            _reports.Add(report);
        }

        //Function that update a report's information if it exists
        public void UpdateReport(int id, Report report)
        {
            var existingReport = _reports.FirstOrDefault(r => r.id == id);
            if (existingReport != null)
            {
                existingReport.id = id;
                existingReport.reportTitle = report.reportTitle;
            }
        } 

        // Function that deletes a report from the list
        public void DeleteReport(int id)
        {
            var report = _reports.FirstOrDefault(s => s.id == id);
            if (report!= null)
            {
                _reports.Remove(report);
            }
        }
    }
}
