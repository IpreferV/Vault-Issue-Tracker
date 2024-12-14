using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manager.Services;
using Model;

namespace Vault_Issue_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Report>> GetReports()
        {
            return Ok(_reportService.GetAllReports());
        }

        [HttpGet("{id}")]
        public ActionResult<Report> GetReport(int id)
        {
            var report = _reportService.GetReportsById(id);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [HttpPost]
        public ActionResult AddReport(Report report)
        {
            _reportService.AddReport(report);
            return CreatedAtAction(nameof(GetReport), new { id = report.id }, report);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateReport(int id, Report report)
        {
            var existingReport = _reportService.GetReportsById(id);
            if (existingReport == null)
            {
                return NotFound();
            }

            _reportService.UpdateReport(id, report);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReport(int id)
        {
            var report = _reportService.GetReportsById(id);
            if (report == null)
            {
                return NotFound();
            }

            _reportService.DeleteReport(id);
            return NoContent();
        }
    }
}