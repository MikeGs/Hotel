using Dual_Hotel_EX3.View;
using Dual_Hotel_EX3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class ClientsController
    {

        Clients cl = new Clients();

        public ClientsController() {

            //

            fillClientsGrid();

            cl.Show();

        }

        private void fillClientsGrid()
        {
            
            //cl.clientsGrid.DataSource = ClientsRepository.

        }
    }
}
