using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICORE.Data;
using WebAPICORE.Models;

namespace WebAPICORE.Controllers
{
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private Context _context;

        public EmployeeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public List<EmployeeDetails> Get()
        {
            return _context.EmployeeDetails.ToList();
        }

        [HttpGet("Id")]
        public EmployeeDetails GetEmployeeDetails(int Id)
        {
            var timetracking = _context.EmployeeDetails.Where(a => a.ID == Id).SingleOrDefault();
            return timetracking;
        }

        [HttpPost]
        public IActionResult PostEmployeeDetails([FromBody] EmployeeDetails empDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            _context.EmployeeDetails.Add(empDetails);
            _context.SaveChanges();

            return Ok();
        }
        [HttpPut]
        public IActionResult PutEmployeeDetails([FromBody] EmployeeDetails empDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            _context.EmployeeDetails.Update(empDetails);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("Id")]
        public async Task<IActionResult> DeleteEmployeeDetails(int Id)
        {
             var empDetails = await _context.EmployeeDetails.FindAsync(Id);

            if (empDetails == null)
            {
                return NotFound();
            }
            _context.EmployeeDetails.Remove(empDetails);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
