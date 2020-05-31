using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer) 
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
