using System;
using System.Collections.Generic;

namespace WebApiOnDocker.Services
{
    public class ClientService
    {
        public List<Client> GetClients()
        {
            return new List<Client> { new Client { Name = "John Smith" }, new Client { Name = "Rick Barlow" }, new Client { Name = "Megan Smith" }, new Client { Name = "Amanda Bayers" } };
        }
    }
}
