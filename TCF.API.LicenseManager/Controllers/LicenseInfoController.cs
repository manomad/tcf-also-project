using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCF.API.LicenseManager.Model;

namespace TCF.API.LicenseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseInfoController : ControllerBase
    {
        private readonly LicenseInfoContext _context;

        public LicenseInfoController(LicenseInfoContext context)
        {
            _context = context;
        }

        // GET: api/licenseInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LicenseInfo>>> GetLicenseInfos()
        {
            return await _context.LicenseInfos.ToListAsync();
        }

        // GET: api/licenseInfo/company/{id}
        [HttpGet("company/{id}")]
        public async Task<ActionResult<IEnumerable<LicenseInfo>>> GetAllLicenseInfosByCompanyId(string id)
        {
            int companyId = int.TryParse(id, out int parsedId) ? parsedId : 0;
            var licenseInfo = await _context.LicenseInfos
                .Where(l => l.customerAccountId == companyId)
                .ToListAsync();

            if (licenseInfo == null || !licenseInfo.Any())
            {
                return NotFound();
            }

            return licenseInfo;
        }

        // GET: api/licenseInfo/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<LicenseInfo>> GetLicenseInfo(string id)
        {
            var licenseInfo = await _context.LicenseInfos.FindAsync(id);

            if (licenseInfo == null)
            {
                return NotFound();
            }

            return licenseInfo;
        }

        // GET: api/licenseInfo/companies
        [HttpGet("companies")]
        public async Task<ActionResult<IEnumerable<object>>> GetCompanies()
        {
            var licenseInfos = await _context.LicenseInfos.ToListAsync();

            var companies = licenseInfos
                .GroupBy(l => new { l.customerAccountId, l.customerName })
                .Select(g => new
                {
                    g.Key.customerAccountId,
                    g.Key.customerName,
                    licenseCount = g.Count()
                })
                .ToList();

            return Ok(companies);
        }
    }
}
