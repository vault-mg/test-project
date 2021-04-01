using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApplication.Internal;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {

        private readonly ILogger<DefaultController> _logger;
        public SecurityProvider SecurityProvider { get; }


        public DefaultController(ILogger<DefaultController> logger, SecurityProvider securityProvider)
        {
            _logger = logger;
            SecurityProvider = securityProvider;
        }


        /// <summary>
        /// Funktion zum Updaten eines Benutzers
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(User user)
        {
            try
            {
                var response = new UpdateResponse();

                SecurityProvider.InitializeSecuritySystem();

                var entity = SecurityProvider.GetUser(user.Id);

                entity.Name = user.Name;

                entity.SaveAsync();

                response.Success = true;
                return Ok(response);
            }
            catch
            {
                _logger.LogError("Error in method: put");
                return BadRequest();
            }
        }
    }
}
