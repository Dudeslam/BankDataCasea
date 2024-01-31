using Bankdata.BusinessLogicBanking;
using Bankdata.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bankdata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountBL _accountBL;

        public AccountController(ILogger<AccountController> logger, IAccountBL accountBL)
        {
            _logger = logger;
            _accountBL = accountBL;
        }


        [HttpGet("Accounts")]
        public IActionResult GetAccounts()
        {
            List<Account> accounts = _accountBL.GetAccounts();

            return accounts.Count() != 0 ? Ok(accounts) : NotFound();
        }

        [HttpGet("Accounts/[id]")]
        public IActionResult GetAccountData(int id)
        {
            return Ok(_accountBL.GetAccount(id));
        }

        [HttpPut("Accounts")]
        public IActionResult CreateAccount(Account acc)
        {
            return Ok(_accountBL.CreateAccount(acc));

        }

        [HttpDelete("Accounts/[id]")]
        public IActionResult DeleteAccount(int id)
        {
            return _accountBL.DeleteAccount(id) == true ? Ok(true) : BadRequest();
        }

        [HttpGet("Transactions/[id]")]
        public IActionResult GetTransaction()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Transfer/[id]")]
        public IActionResult TransferSum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
