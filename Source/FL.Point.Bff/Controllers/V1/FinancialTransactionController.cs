﻿using FL.Point.Bff.Controllers.Base;
using FL.Model;
using Microsoft.AspNetCore.Mvc;

namespace FL.Point.Bff.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialTransactionController : BaseController
    {

        public FinancialTransactionController() : base () 
        { 

        }

        /// <summary>
        /// Get a Financial Transaction by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetFinancialTransaction/{id:int}")]
        public async Task<ActionResult<FinancialTransaction>> Get(int id)
        {
            var output = await GetById<FinancialTransaction>("GetFinancialTransaction/", id);

            return Ok(output);
        }

        /// <summary>
        /// Save the transaction
        /// </summary>
        /// <param name="financialTransaction"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(FinancialTransaction financialTransaction)
        {
            var output = await PostAsync<FinancialTransaction>("GetFinancialTransaction/", financialTransaction);

            return Ok(output);
        }

    }
}