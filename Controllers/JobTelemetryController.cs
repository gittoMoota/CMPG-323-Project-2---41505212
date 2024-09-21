using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _41505212__API.Models;
using Microsoft.AspNetCore.Authorization;


namespace _41505212__API.Models
{
    [AllowAnonymous]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TelemetryController : ControllerBase
    {
        private readonly NwutechTrendsContext _context;

        public TelemetryController(NwutechTrendsContext context)
        {
            _context = context;
        }

        // GET: api/Telemetry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTelemetry>>> GetAllTelementry()
        {
            var telemetryData = await _context.JobTelemetries.ToListAsync();
            return Ok(telemetryData);
        }

        // GET: api/Telemetry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobTelemetry>> GetTelemetry(int id)
        {
            var telemetry = await _context.JobTelemetries.FindAsync(id);

            if (telemetry == null)
            {
                return NotFound();
            }

            return Ok(telemetry);
        }

        // POST: api/Telemetry
        [HttpPost]
        public async Task<ActionResult<JobTelemetry>> CreateTelemetry(JobTelemetry telemetry)
        {
            _context.JobTelemetries.Add(telemetry);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTelemetry), new { id = telemetry.Id }, telemetry);
        }

        // PATCH: api/Telemetry/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateTelemetry(int id, JobTelemetry telemetry)
        {
            if (id != telemetry.Id)
            {
                return BadRequest();
            }

            _context.Entry(telemetry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelemetryExists(id))
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

        // DELETE: api/Telemetry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTelemetry(int id)
        {
            var telemetry = await _context.JobTelemetries.FindAsync(id);
            if (telemetry == null)
            {
                return NotFound();
            }

            _context.JobTelemetries.Remove(telemetry);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        // Private method to check if Telemetry exists
        private bool TelemetryExists(int id)
        {
            return _context.JobTelemetries.Any(e => e.Id == id);
        }


    }
}
