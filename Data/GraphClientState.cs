using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace BlazorAuthApp.Data
{
    public class GraphClientState
    {
        public string EntityId { get; set; }
        public string AccessToken { get; set; }
        public Message[] Messages { get; set; }
    }
}
