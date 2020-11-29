﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vote.Models;

namespace VoteServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotingController1 : ControllerBase
    {
        private static List<OptionVoting> votings = new List<OptionVoting>();

        [HttpGet]
        public IEnumerable<OptionVoting> GetAll() {
            return votings;
        }

        [HttpPost("create")]
        public IActionResult Create(OptionVoting model) {
            if (model == null) {
                return BadRequest();
            }
            votings.Add(model);
            return Ok();
        }
    }
}