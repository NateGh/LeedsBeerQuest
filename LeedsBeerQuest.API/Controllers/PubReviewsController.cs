using LeedsBeerQuest.API.Models;
using LeedsBeerQuest.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PubReviewsController : ControllerBase
    {
        private readonly IPubReviewService pubReviewService;
        public PubReviewsController(IPubReviewService pubReviewService)
        
        
        {
            this.pubReviewService = pubReviewService;
        }

        [HttpGet]
        [Route("pubs")]
        public IEnumerable<Pub> Get()
        {
            var pubs =  pubReviewService.GetPubsAsync();
            return pubs.Result;
        }
    }
}
