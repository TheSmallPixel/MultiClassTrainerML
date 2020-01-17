using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QueSinistriCoinvolti
    {
        public int IdSinistrocoinvolto { get; set; }
        public int IdQuerela { get; set; }
        public int IdSinistro { get; set; }
        public string FlgPrincipaleSino { get; set; }
    }
}
