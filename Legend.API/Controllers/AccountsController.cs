using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Legend.Domain.Entities;
using Legend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Legend.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class AccountsController : ControllerBase
    {
        public readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetAccountList()
        {
            var accountsList = await _accountService.GetAllAccounts();
            if (accountsList == null)
            {
                return NotFound();
            }
            return Ok(accountsList);
        }

        // GET api/values/5

       /* [HttpGet("{accountId}")]
        public async Task<IActionResult> GetAccountById(int accountId)
        {
            var account = await _accountService.GetAccountById(accountId);

            if (account != null)
            {
                return Ok(account);
            }
            else
            {
                return BadRequest();
            }
        }*/

        [HttpGet("{email}")]
        public async Task<IActionResult> GetAccountByEmail(string email)
        {
            var account = await _accountService.GetAccountByEmail(email);

            if (account != null)
            {
                return Ok(account);
            }
            else
            {
                return BadRequest();
            }
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreateAccount(Account account)
        {
            var isAccountCreated = await _accountService.CreateAccount(account);

            if (isAccountCreated)
            {
                return Ok(isAccountCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateAccount(Account account)
        {
            if (account != null)
            {
                var isAccountCreated = await _accountService.UpdateAccount(account);
                if (isAccountCreated)
                {
                    return Ok(isAccountCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{accountId}")]
        public async Task<IActionResult> DeleteAccount(int accountId)
        {
            var isAccountCreated = await _accountService.DeleteAccount(accountId);

            if (isAccountCreated)
            {
                return Ok(isAccountCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

