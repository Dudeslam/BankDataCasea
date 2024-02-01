using Bankdata.BusinessLogicBanking;
using Bankdata.Models;
using Bankdata.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bankdata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ITransactionBL _transactionBL;
        private readonly IAccountBL _accountBL;

        public AccountController(ILogger<AccountController> logger, IAccountBL accountBL, ITransactionBL transactionBL)
        {
            _logger = logger;
            _accountBL = accountBL;
            _transactionBL = transactionBL;
        }


        [HttpGet("Accounts")]
        public IActionResult GetAccounts()
        {
            List<AccountDTO> accounts = _accountBL.GetAccounts();
            return accounts.Count() != 0 ? Ok(accounts) : NotFound();
        }

        [HttpGet("Accounts/{id}")]
        public IActionResult GetAccountData(int id)
        {
            var accountData = _accountBL.GetAccount(id);
            return accountData != null ? Ok(accountData) : NotFound();
        }

        [HttpPost("Accounts")]
        public IActionResult CreateAccount(AccountDTO acc)
        {

            return Ok(_accountBL.CreateAccount(acc));
        }

        [HttpDelete("Accounts/{id}")]
        public IActionResult DeleteAccount(int id)
        {
            return _accountBL.DeleteAccount(id) == true ? Ok(true) : BadRequest();
        }

        [HttpGet("AccountTransactions/{id}")]
        public IActionResult GetTransactionsFromAccount(int id)
        {
            return Ok(_transactionBL.GetAllTransaction(id));
        }

        [HttpGet("Transaction/{id}")]
        public IActionResult GetTransaction(int id)
        {
            return Ok(_transactionBL.GetTransaction(id));

        }

        [HttpPost("Transfer/{id}")]
        public IActionResult TransferSum(int provId, int recId, int sum)
        {
            var dto = new TransactionDTO(provId, recId, sum, DateTime.UtcNow);
            if( _accountBL.GetAccount(provId)?.Balance >= sum  && _transactionBL.Transfer(dto))
            {
                _accountBL.UpdateAccount(provId, -sum);
                _accountBL.UpdateAccount(recId, sum);
                return Ok();
            }
            return NotFound();
        }
    }
}
