using BigSchool.Models;
using System.Linq;
using System.Web.Http;

namespace BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        // GET: api/Attendances
        public IQueryable<Attendance> GetAttendances()
        {
            return _dbContext.Attendances;
        }

    } 
}