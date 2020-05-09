using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiOnDocker.Model;
using WebApiOnDocker.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiOnDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        // GET: /<controller>/
        public List<ClientModel> Index()
        {
            ClientService clientService = new ClientService();
            return ToClientModel(clientService.GetClients());
        }
        [NonAction]
        private List<ClientModel> ToClientModel(List<Client> clients)
        {
            return clients.Select(x => new ClientModel { Name= x.Name }).ToList();
        }
    }
}
