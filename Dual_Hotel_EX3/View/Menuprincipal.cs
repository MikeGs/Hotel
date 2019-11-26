using Dual_Hotel_EX3.Controller;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.View
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();

        }

        private void AfegirClientsB_Click(object sender, EventArgs e)
        {
            AfegirClient ac = new AfegirClient();
            ac.Show();
        }

        private void AfegirHostesB_Click(object sender, EventArgs e)
        {
            AfegirHoste ah = new AfegirHoste();
            ah.Show();
        }

        private void UltimesReservesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientsB_Click(object sender, EventArgs e)
        {

            ClientsController cc = new ClientsController();

        }
    }
}
