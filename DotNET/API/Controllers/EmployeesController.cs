using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Api.Controllers
{
    [RoutePrefix("api/Emp")]
    public class EmployeesController : ApiController
    {
        private DBCompanyEntities db = new DBCompanyEntities();

        // GET: api/Employees
        [HttpGet]
        [Route("AllEmployee")]
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }

        // GET: api/Employees/5
        [HttpGet]
        [ResponseType(typeof(Employee))]
        [Route("SpecificEmployee")]
        // https://localhost:44346/api/Emp/SpecificEmployee?id=1&state=browser
        public async Task<IHttpActionResult> GetEmployee(int id, string state)
        {
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [HttpPut]
        [ResponseType(typeof(void))]
        [Route("UpdateEmployee")]
        public async Task<IHttpActionResult> PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EMPLOYEE_ID)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [HttpPost]
        [ResponseType(typeof(Employee))]
        [Route("AddEmployee")]
        public async Task<IHttpActionResult> PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employees.Add(employee);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = employee.EMPLOYEE_ID }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete]
        [ResponseType(typeof(Employee))]
        [Route("DeleteEmployee")]
        public async Task<IHttpActionResult> DeleteEmployee(int id)
        {
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            await db.SaveChangesAsync();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.EMPLOYEE_ID == id) > 0;
        }
    }
}