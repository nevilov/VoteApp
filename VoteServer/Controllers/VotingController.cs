using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.Models;

namespace VoteServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotingController : ControllerBase
    {
        private static List<OptionVoting> votings = new List<OptionVoting>();
        private readonly VoteDBContext context;

        public VotingController(VoteDBContext context) {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<OptionVoting> GetAll() {
            return context.VoteInfos.Select(v => new OptionVoting {
                TitleVoting = v.TitleVoting,
                DescriptionVoting = v.DescriptionVoting,
                Start_dateVoting = v.Start_dateVoting,
                End_dateVoting = v.End_dateVoting
            });
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(OptionVoting model) {

            if (model == null) {
                return BadRequest();
            }

            context.VoteInfos.Add(new VoteInfo {
                TitleVoting = model.TitleVoting,
                DescriptionVoting = model.DescriptionVoting,
                Start_dateVoting = model.Start_dateVoting,
                End_dateVoting = model.End_dateVoting

            });
            await context.SaveChangesAsync();

            return Ok();
        }


        // DELETE: api/VoteInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VoteInfo>> DeleteVoteInfo(string id) {
            var voteInfo = await context.VoteInfos.FindAsync(id);
            if (voteInfo == null) {
                return NotFound();
            }

            context.VoteInfos.Remove(voteInfo);
            await context.SaveChangesAsync();

            return voteInfo;
        }

        // GET: api/VoteInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoteInfo>> GetVoteInfo(string id) {
            var voteInfo = await context.VoteInfos.FindAsync(id);

            if (voteInfo == null) {
                return NotFound();
            }

            return voteInfo;
        }



    }
}
