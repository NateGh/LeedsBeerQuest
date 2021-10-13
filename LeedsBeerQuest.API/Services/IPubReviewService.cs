using LeedsBeerQuest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Services
{
    public interface IPubReviewService
    {
        Task<List<Pub>> GetPubsAsync();
        Task<List<Review>> GetPubReviews(string pubName);
    }
}
