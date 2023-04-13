using APP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;

namespace APP1.Controllers
{
    public class HomeController : Controller
    {
        private string conn = "Server=BATYA\\SQLEXPRESS; Database=kps_rtz; Trusted_Connection=True; TrustServerCertificate=True;";
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? regNumber)
        {
            using (IDbConnection dbi = new SqlConnection(conn))
            {
                string sqlQuery = "SELECT * FROM Package";
                var ALL = dbi.Query<Package>(sqlQuery);
                var P = from p in ALL where p.RegNumber == regNumber select p;
                return View(P.FirstOrDefault());
            }
        }

        public IActionResult Index2(string? regNumber)
        {
            using (IDbConnection dbi = new SqlConnection(conn))
            {
                string sqlQuery2 = @$"select p.RegNumber, d.number, d.Name, d.authorid, p.applicantid, d.createdate, d.transferdate
                                'TransferDate Прочитано/ скачано', p.name p_name, dt.Name, d.status d_status, a.Name a_name, d.Name, 
                                p.Status p_status, p.ApplicationType, p.regnumber, d.TypeDocumentId, d.regdate, d.createdate, d.creationdate, 
                                d.id,  d.packageid, si.SigningDate, si.Signature, si.Id signatureId,d.FileName, d.FilePath,  d.TypeDocumentId
                                from Document d left join DocumentType dt on(dt.[Id] = d.[TypeDocumentId])
                                left join Package p on(d.[PackageId] = p.[Id]) left join Applicant a on(a.Id = p.[ApplicantId])
                                left join SignatureInfo si on si.DocumentId = d.Id where RegNumber in ('{regNumber}')";
                var ALL = dbi.ExecuteReader(sqlQuery2);
                DataTable table = new DataTable();
                table.Load(ALL);
                return View(table);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
