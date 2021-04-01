using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Internal
{
    public class UpdateResponse
    {
        public bool Success { get; set; }

    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public async Task<bool> SaveAsync()
        {          
            return  new Random().Next(2) == 1;
        }
    }
}
