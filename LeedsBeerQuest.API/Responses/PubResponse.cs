using LeedsBeerQuest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Responses
{
    public class PubResponse
    {
        public Info Info { get; set; }
        public List<Pub> Rows { get; set; }
    }

    public class Info
    {
        public int Total { get; set; }
        public int Rows { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Pages { get; set; }
        public string NextPage { get; set; }
        public string LastPage { get; set; }

    }
}
