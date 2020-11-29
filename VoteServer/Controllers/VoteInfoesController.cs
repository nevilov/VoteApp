﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoteServer;

namespace VoteServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteInfoesController : ControllerBase
    {
        private readonly VoteDBContext _context;

        public VoteInfoesController(VoteDBContext context)
        {
            _context = context;
        }

        // GET: api/VoteInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoteInfo>>> GetVoteInfos()
        {
            return await _context.VoteInfos.ToListAsync();
        }

        // GET: api/VoteInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoteInfo>> GetVoteInfo(string id)
        {
            var voteInfo = await _context.VoteInfos.FindAsync(id);

            if (voteInfo == null)
            {
                return NotFound();
            }

            return voteInfo;
        }

        // PUT: api/VoteInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoteInfo(string id, VoteInfo voteInfo)
        {
            if (id != voteInfo.TitleVoting)
            {
                return BadRequest();
            }

            _context.Entry(voteInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoteInfoExists(id))
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

        // POST: api/VoteInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VoteInfo>> PostVoteInfo(VoteInfo voteInfo)
        {
            _context.VoteInfos.Add(voteInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoteInfo", new { id = voteInfo.TitleVoting }, voteInfo);
        }

        // DELETE: api/VoteInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VoteInfo>> DeleteVoteInfo(string id)
        {
            var voteInfo = await _context.VoteInfos.FindAsync(id);
            if (voteInfo == null)
            {
                return NotFound();
            }

            _context.VoteInfos.Remove(voteInfo);
            await _context.SaveChangesAsync();

            return voteInfo;
        }

        private bool VoteInfoExists(string id)
        {
            return _context.VoteInfos.Any(e => e.TitleVoting == id);
        }
    }
}