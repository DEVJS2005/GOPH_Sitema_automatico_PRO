﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Projeto_S.A.L__PRO_
{
    public partial class telainicial : Form
    {
        Thread HomepageT1;
        public telainicial()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            HomepageT1 = new Thread(abrirJanela);
            HomepageT1.SetApartmentState(ApartmentState.STA);
            HomepageT1.Start();
            this.Close();
        }
        private void abrirJanela(object obj)
        {
            Application.Run(new telaprincipal());
        }
    }
}
