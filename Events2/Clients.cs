using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public class ClientList
    {
        List<Client> clients = new List<Client>();

        public void Add(Client client)
        {
            //Validations.......
            clients.Add(client);
            //OnClientAdded();
        }

        public void Remove(Client client)
        {
            //Validations.......

            clients.Remove(client);
            //OnClientAdded();
        }

    }
}
