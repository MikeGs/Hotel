using Dual_Hotel_EX3.View;
using Dual_Hotel_EX3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.Controller
{
    public class ClientsController
    {

        Clients cl = new Clients();

        BindingSource clientsBinding = new BindingSource();

        public ClientsController() {

            //

            fillClientsGrid();

            cl.Show();

        }

        private void fillClientsGrid()
        {

            clientsBinding.DataSource = ClientsRepository.getClients();
            cl.clientsGrid.DataSource = clientsBinding;

        }
    }
}
