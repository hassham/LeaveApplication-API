using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveApplication.API;
using LeaveApplication.API.Model;

namespace LeaveApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveApplicationRequestsController : ControllerBase
    {
        private readonly MyDataContext _context;

        public LeaveApplicationRequestsController(MyDataContext context)
        {
            _context = context;
        }

        // GET: api/LeaveApplicationRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveApplicationRequest>>> GetLeaveApplicationRequests()
        {
            return await _context.LeaveApplicationRequests.ToListAsync();
        }

        // GET: api/LeaveApplicationRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveApplicationRequest>> GetLeaveApplicationRequest(int id)
        {
            var leaveApplicationRequest = await _context.LeaveApplicationRequests.FindAsync(id);

            if (leaveApplicationRequest == null)
            {
                return NotFound();
            }

            return leaveApplicationRequest;
        }

        // PUT: api/LeaveApplicationRequests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeaveApplicationRequest(int id, LeaveApplicationRequest leaveApplicationRequest)
        {
            if (id != leaveApplicationRequest.Id)
            {
                return BadRequest();
            }

            _context.Entry(leaveApplicationRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveApplicationRequestExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LeaveApplicationRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LeaveApplicationRequest>> PostLeaveApplicationRequest(LeaveApplicationRequest leaveApplicationRequest)
        {
            _context.LeaveApplicationRequests.Add(leaveApplicationRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLeaveApplicationRequest", new { id = leaveApplicationRequest.Id }, leaveApplicationRequest);
        }

        // DELETE: api/LeaveApplicationRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeaveApplicationRequest(int id)
        {
            var leaveApplicationRequest = await _context.LeaveApplicationRequests.FindAsync(id);
            if (leaveApplicationRequest == null)
            {
                return NotFound();
            }

            _context.LeaveApplicationRequests.Remove(leaveApplicationRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LeaveApplicationRequestExists(int id)
        {
            return _context.LeaveApplicationRequests.Any(e => e.Id == id);
        }
    }
}
