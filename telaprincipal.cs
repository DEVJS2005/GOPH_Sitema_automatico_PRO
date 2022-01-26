using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_S.A.L__PRO_
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
            gpboxNumb.Visible = false;
            txboxCorpoList.Visible = false;
            btnCriarCabecario.Visible = false;
            btnGerar.Visible = false;


            txBoxName.ReadOnly = true;
            txBoxAliadaVisi.ReadOnly = true;
            btnListar.Visible = false;
            btnConcluir.Visible = false;
        }
        public void tardeNoiteoff()
        {
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
            rdbNoite1.Checked = false;
            rdbNoite2.Checked = false;
            rdbNoite3.Checked = false;
        }
        public void tardeOff()
        {
            rdbTarde1.Checked = false;
            rdbTarde2.Checked = false;
        }
        public void noiteOff()
        {
            rdbNoite1.Checked = false;
            rdbNoite2.Checked = false;
            rdbNoite3.Checked = false;
        }
        public void limparCampos()
        {
            txBoxName.Text = "";
            txBoxAliadaVisi.Text = "";
        }

        string data = DateTime.Now.ToString("dd-MM-yyyy");
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string Turno = "";
        int ciclo = 0;
        int visitas = 0;


        // Panel de Listar
        List<Funcio> listaFuncio = new List<Funcio>();

        private void rdbTarde_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = false;
            gpboxNumb.Visible = true;
            //Tarde:
            lblTarde.Visible = true;
            rdbTarde1.Visible = true;
            rdbTarde2.Visible = true;
            //Desabilita a visibilidade da noite para não haver confusão
            lblNoite.Visible = false;
            rdbNoite1.Visible = false;
            rdbNoite2.Visible = false;
            rdbNoite3.Visible = false;
            //desmarcação da caixa da noite
            noiteOff();
        }

        private void rdbNoite_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = false;
            gpboxNumb.Visible = true;
            lblNoite.Visible = true;
            rdbNoite1.Visible = true;
            rdbNoite2.Visible = true;
            rdbNoite3.Visible = true;
            //Desabilita a visibilidade da tarde para não haver confusão
            lblTarde.Visible = false;
            rdbTarde1.Visible = false;
            rdbTarde2.Visible = false;
            //desabilita a marcação na caixa da tarde 
            tardeOff();
        }

        private void rdbTarde1_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            noiteOff();

        }

        private void rdbTarde2_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            noiteOff();
        }

        private void rdbNoite1_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            tardeOff();
        }

        private void rdbNoite2_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            tardeOff();
        }

        private void rdbNoite3_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            tardeOff();
        }

        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            tardeNoiteoff();
            gpboxNumb.Visible = false;
        }

        private void rdbMadrugada_CheckedChanged(object sender, EventArgs e)
        {
            btnCriarCabecario.Visible = true;
            tardeNoiteoff();
            gpboxNumb.Visible = false;
        }

        private void btnCriarCabecario_Click(object sender, EventArgs e)
        {
            StreamWriter lista = new StreamWriter(desktop + "\\Lista_Automatica.txt");
            if(txBoxComando.Text != "")
            {
                // verificação do turno do ciclo
                if (rdbManha.Checked)
                {
                    Turno = "Manhã";
                    visitas = 9;
                    tardeNoiteoff();
                }
                else if (rdbTarde.Checked)
                {
                    Turno = "Tarde";
                    // verificação do numero do ciclo
                    if (rdbTarde1.Checked)
                    {
                        ciclo = 1;
                        visitas = 6;
                    }
                    else if (rdbTarde2.Checked)
                    {
                        ciclo = 2;
                        visitas = 6;
                    }

                }
                else if (rdbNoite.Checked)
                {
                    Turno = "Noite";
                    if (rdbNoite1.Checked)
                    {
                        ciclo = 1;
                        visitas = 9;
                    }
                    else if (rdbNoite2.Checked)
                    {
                        ciclo = 2;
                        visitas = 9;
                    }
                    else if (rdbNoite3.Checked)
                    {
                        ciclo = 3;
                        visitas = 9;
                    }
                }
                else if (rdbMadrugada.Checked)
                {
                    Turno = "Madrugada";
                    tardeNoiteoff();
                }
                if (txBoxAuxLista.Text == "")
                {
                    txBoxAuxLista.Text = txBoxComando.Text;
                }
                // preenchimento por turno
                switch (Turno)
                {
                    case "Manhã":
                        lista.WriteLine("Data:" + data);
                        lista.WriteLine("Turno:Manhã");
                        lista.WriteLine("Ciclo:01");
                        lista.WriteLine("Código:01");
                        lista.WriteLine("Hora de inicio:10:30");
                        lista.WriteLine("Hora de fim:12:00");
                        lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                        lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                        lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                        lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                        break;
                    case "Tarde":
                        lista.WriteLine("data:" + data);
                        lista.WriteLine("Turno:Tarde");
                        lista.WriteLine("Ciclo:" + ciclo);
                        lista.WriteLine("Código: 01");
                        if (ciclo == 1)
                        {
                            lista.WriteLine("Hora de inicio:14:00");
                            lista.WriteLine("Hora de fim:15:00");
                        }
                        else if (ciclo == 2)
                        {
                            lista.WriteLine("Hora de inicio:15:30");
                            lista.WriteLine("Hora de fim:16:30");
                        }
                        lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                        lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                        lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                        lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                        break;
                    case "Noite":
                        lista.WriteLine("data:" + data);
                        lista.WriteLine("Turno:Noite");
                        lista.WriteLine("Ciclo:" + ciclo);
                        lista.WriteLine("Código: 01");
                        if (ciclo == 1)
                        {
                            lista.WriteLine("Hora de inicio:17:30");
                            lista.WriteLine("Hora de fim:19:00");
                        }
                        else if (ciclo == 2)
                        {
                            lista.WriteLine("Hora de inicio:19:30");
                            lista.WriteLine("Hora de fim:21:00");
                        }
                        else if (ciclo == 3)
                        {
                            lista.WriteLine("Hora de inicio:21:30");
                            lista.WriteLine("Hora de fim:23:00");
                        }
                        lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                        lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                        lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                        lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                        break;
                    case "Madrugada":
                        lista.WriteLine("Data:" + data);
                        lista.WriteLine("Turno:Madrugada");
                        lista.WriteLine("Ciclo:01");
                        lista.WriteLine("Código:01");
                        lista.WriteLine("Hora de inicio:00:00");
                        lista.WriteLine("Hora de fim:00:03");
                        lista.WriteLine("Comandante do código:" + txBoxComando.Text);
                        lista.WriteLine("Co.comandante do código:" + txBoxCoComando.Text);
                        lista.WriteLine("Auxiliar da lista:" + txBoxAuxLista.Text);
                        lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema)");
                        break;

                }
                lista.Close();
                txBoxComando.ReadOnly = true;
                txBoxCoComando.ReadOnly = true;
                txBoxAuxLista.ReadOnly = true;
                btnCriarCabecario.Visible = false;
                gpboxTurno.Visible = false;
                gpboxNumb.Visible = false;

                txBoxName.ReadOnly = false;
                txBoxAliadaVisi.ReadOnly = false;
                btnListar.Visible = true;
                btnConcluir.Visible = true;
            }
            else { MessageBox.Show("ERRO!!! Um ciclo não pode ser feito sem um comandante."); }
        }

        
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificação de repetição 
            for (int i = 0; i < listaFuncio.Count; i++)
            {
                if (listaFuncio[i].getNome().Equals(txBoxName.Text) & listaFuncio[i].getAliadas() != txBoxAliadaVisi.Text)
                {
                    listaFuncio[i].AlterAliadas(txBoxAliadaVisi.Text);
                    txboxPreVisual.Text = string.Format("As aliadas de {0} foram  alteradas", txBoxName.Text);
                    limparCampos();
                }

            }
            if (txBoxName.Text != "" & txBoxAliadaVisi.Text != "")
            {
                listaFuncio.Add(new Funcio(txBoxName.Text, txBoxAliadaVisi.Text));
                txboxPreVisual.Text = String.Format("Nick:{0} \r\n Aliadas visitadas:{1}", txBoxName.Text, txBoxAliadaVisi.Text);
                limparCampos();
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txboxCorpoList.Visible = true;

            string listaAliadas = listaFuncio[0].getAliadas();
            string[] Aliadas = listaAliadas.Split(',', ';');
            List<string> listVisitas = new List<string>();

            foreach (string element in Aliadas)
            {
                listVisitas.Add(element);
            }
            if (listVisitas.Count() < visitas)
            {
                while (listVisitas.Count() < visitas)
                {
                    listVisitas.Add("-x-");
                }
            }


            using (StreamWriter lst = File.AppendText(desktop + "\\Lista_Automatica.txt"))
            {

                for (int o = 0; o < listaFuncio.Count; o++)
                {

                    lst.WriteLine("Nick:{0}", listaFuncio[o].getNome());
                    lst.WriteLine("Aliadas visitadas:{0}", listaFuncio[o].getAliadas());
                    lst.WriteLine("-");
                    lst.WriteLine("-");
                }
                switch (Turno)
                {
                    case "Manhã":
                        lst.WriteLine("Aliadas Visitadas:");
                        lst.WriteLine("{0}:10:30 ás 10:40", listVisitas[0]);
                        lst.WriteLine("{0}:10:40 ás 10:50", listVisitas[1]);
                        lst.WriteLine("{0}:10:50 ás 11:00", listVisitas[2]);
                        lst.WriteLine("{0}:11:00 ás 11:10", listVisitas[3]);
                        lst.WriteLine("{0}:11:10 ás 11:20", listVisitas[4]);
                        lst.WriteLine("{0}:11:20 ás 11:30", listVisitas[5]);
                        lst.WriteLine("{0}:11:30 ás 11:40", listVisitas[6]);
                        lst.WriteLine("{0}:11:40 ás 11:50", listVisitas[7]);
                        lst.WriteLine("{0}:11:50 ás 12:00", listVisitas[8]);
                        break;
                    case "Tarde":
                        if (rdbTarde1.Checked)
                        {
                            lst.WriteLine("Aliadas Visitadas:");
                            lst.WriteLine("{0}:14:00 ás 14:10", listVisitas[0]);
                            lst.WriteLine("{0}:14:10 ás 14:20", listVisitas[1]);
                            lst.WriteLine("{0}:14:20 ás 14:30", listVisitas[2]);
                            lst.WriteLine("{0}:14:30 ás 14:40", listVisitas[3]);
                            lst.WriteLine("{0}:14:40 ás 14:50", listVisitas[4]);
                            lst.WriteLine("{0}:14:50 ás 15:00", listVisitas[5]);
                        }
                        else if (rdbTarde2.Checked)
                        {
                            lst.WriteLine("Aliadas Visitadas:");
                            lst.WriteLine("{0}:15:30 ás 15:40", listVisitas[0]);
                            lst.WriteLine("{0}:15:40 ás 15:50", listVisitas[1]);
                            lst.WriteLine("{0}:15:50 ás 16:00", listVisitas[2]);
                            lst.WriteLine("{0}:16:00 ás 16:10", listVisitas[3]);
                            lst.WriteLine("{0}:16:10 ás 16:20", listVisitas[4]);
                            lst.WriteLine("{0}:16:20 ás 16:30", listVisitas[5]);
                        }
                        break;
                    case "Noite":
                        if (rdbNoite1.Checked)
                        {
                            lst.WriteLine("Aliadas Visitadas:");
                            lst.WriteLine("{0}:17:30 ás 17:40", listVisitas[0]);
                            lst.WriteLine("{0}:17:40 ás 17:50", listVisitas[1]);
                            lst.WriteLine("{0}:17:50 ás 18:00", listVisitas[2]);
                            lst.WriteLine("{0}:18:00 ás 18:10", listVisitas[3]);
                            lst.WriteLine("{0}:18:10 ás 18:20", listVisitas[4]);
                            lst.WriteLine("{0}:18:20 ás 18:30", listVisitas[5]);
                            lst.WriteLine("{0}:18:30 ás 18:40", listVisitas[6]);
                            lst.WriteLine("{0}:18:40 ás 18:50", listVisitas[7]);
                            lst.WriteLine("{0}:18:50 ás 19:00", listVisitas[8]);
                        }
                        else if (rdbNoite2.Checked)
                        {
                            lst.WriteLine("Aliadas Visitadas:");
                            lst.WriteLine("{0}:19:30 ás 19:40", listVisitas[0]);
                            lst.WriteLine("{0}:19:40 ás 19:50", listVisitas[1]);
                            lst.WriteLine("{0}:19:50 ás 20:00", listVisitas[2]);
                            lst.WriteLine("{0}:20:00 ás 20:10", listVisitas[3]);
                            lst.WriteLine("{0}:20:10 ás 20:20", listVisitas[4]);
                            lst.WriteLine("{0}:20:20 ás 20:30", listVisitas[5]);
                            lst.WriteLine("{0}:20:30 ás 20:40", listVisitas[6]);
                            lst.WriteLine("{0}:20:40 ás 20:50", listVisitas[7]);
                            lst.WriteLine("{0}:20:50 ás 21:00", listVisitas[8]);
                        }
                        else if (rdbNoite3.Checked)
                        {
                            lst.WriteLine("Aliadas Visitadas:");
                            lst.WriteLine("{0}:21:30 ás 21:40", listVisitas[0]);
                            lst.WriteLine("{0}:21:40 ás 21:50", listVisitas[1]);
                            lst.WriteLine("{0}:21:50 ás 22:00", listVisitas[2]);
                            lst.WriteLine("{0}:22:00 ás 22:10", listVisitas[3]);
                            lst.WriteLine("{0}:22:10 ás 22:20", listVisitas[4]);
                            lst.WriteLine("{0}:22:20 ás 22:30", listVisitas[5]);
                            lst.WriteLine("{0}:22:30 ás 22:40 ", listVisitas[6]);
                            lst.WriteLine("{0}:22:40 ás 22:50 ", listVisitas[7]);
                            lst.WriteLine("{0}:22:50 ás 23:00 ", listVisitas[8]);
                        }
                        break;
                    case "Madrugada":
                        lst.WriteLine("Aliadas Visitadas:");
                        lst.WriteLine("{0}:00:00 ás 00:10", listVisitas[0]);
                        lst.WriteLine("{0}:00:10 ás 00:20", listVisitas[1]);
                        lst.WriteLine("{0}:00:20 ás 00:30", listVisitas[2]);
                        lst.WriteLine("{0}:00:30 ás 00:40", listVisitas[3]);
                        lst.WriteLine("{0}:00:40 ás 00:50", listVisitas[4]);
                        lst.WriteLine("{0}:00:50 ás 01:00", listVisitas[5]);
                        lst.WriteLine("{0}:01:00 ás 01:10 ", listVisitas[6]);
                        lst.WriteLine("{0}:01:10 ás 01:20 ", listVisitas[7]);
                        lst.WriteLine("{0}:01:30 ás 01:40 ", listVisitas[8]);
                        break;
                }
                lst.WriteLine("");
                lst.WriteLine("");
                lst.WriteLine("Gerado pelo Sistema Automático de Lista(S.A.L) ρrσ ®");
                lst.Close();
            }
            StreamReader lista = new StreamReader(desktop + "\\Lista_Automatica.txt");
            string linha;
            do
            {
                linha = lista.ReadToEnd();

                txboxCorpoList.Text = linha;
                linha = lista.ReadLine();
            } while (linha != null);
            lista.Close();

            btnConcluir.Visible = false;
            btnListar.Visible = false;
            btnGerar.Visible = true;

        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
