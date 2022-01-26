
namespace Projeto_S.A.L__PRO_
{
    partial class telaprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaprincipal));
            this.pnCriacao = new System.Windows.Forms.Panel();
            this.gpboxNumb = new System.Windows.Forms.GroupBox();
            this.rdbNoite3 = new System.Windows.Forms.RadioButton();
            this.lblNoite = new System.Windows.Forms.Label();
            this.rdbNoite2 = new System.Windows.Forms.RadioButton();
            this.lblTarde = new System.Windows.Forms.Label();
            this.rdbNoite1 = new System.Windows.Forms.RadioButton();
            this.rdbTarde1 = new System.Windows.Forms.RadioButton();
            this.rdbTarde2 = new System.Windows.Forms.RadioButton();
            this.gpboxTurno = new System.Windows.Forms.GroupBox();
            this.rdbMadrugada = new System.Windows.Forms.RadioButton();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.btnCriarCabecario = new System.Windows.Forms.Button();
            this.txBoxAuxLista = new System.Windows.Forms.TextBox();
            this.txBoxCoComando = new System.Windows.Forms.TextBox();
            this.txBoxComando = new System.Windows.Forms.TextBox();
            this.lblAuxiliar = new System.Windows.Forms.Label();
            this.lblCocomando = new System.Windows.Forms.Label();
            this.lblComandante = new System.Windows.Forms.Label();
            this.pnDefinicao = new System.Windows.Forms.Panel();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txboxCorpoList = new System.Windows.Forms.TextBox();
            this.txboxPreVisual = new System.Windows.Forms.TextBox();
            this.txBoxAliadaVisi = new System.Windows.Forms.TextBox();
            this.txBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCriacao.SuspendLayout();
            this.gpboxNumb.SuspendLayout();
            this.gpboxTurno.SuspendLayout();
            this.pnDefinicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCriacao
            // 
            this.pnCriacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCriacao.Controls.Add(this.gpboxNumb);
            this.pnCriacao.Controls.Add(this.gpboxTurno);
            this.pnCriacao.Controls.Add(this.btnCriarCabecario);
            this.pnCriacao.Controls.Add(this.txBoxAuxLista);
            this.pnCriacao.Controls.Add(this.txBoxCoComando);
            this.pnCriacao.Controls.Add(this.txBoxComando);
            this.pnCriacao.Controls.Add(this.lblAuxiliar);
            this.pnCriacao.Controls.Add(this.lblCocomando);
            this.pnCriacao.Controls.Add(this.lblComandante);
            this.pnCriacao.Location = new System.Drawing.Point(3, 12);
            this.pnCriacao.Name = "pnCriacao";
            this.pnCriacao.Size = new System.Drawing.Size(360, 558);
            this.pnCriacao.TabIndex = 0;
            // 
            // gpboxNumb
            // 
            this.gpboxNumb.Controls.Add(this.rdbNoite3);
            this.gpboxNumb.Controls.Add(this.lblNoite);
            this.gpboxNumb.Controls.Add(this.rdbNoite2);
            this.gpboxNumb.Controls.Add(this.lblTarde);
            this.gpboxNumb.Controls.Add(this.rdbNoite1);
            this.gpboxNumb.Controls.Add(this.rdbTarde1);
            this.gpboxNumb.Controls.Add(this.rdbTarde2);
            this.gpboxNumb.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpboxNumb.Location = new System.Drawing.Point(3, 403);
            this.gpboxNumb.Name = "gpboxNumb";
            this.gpboxNumb.Size = new System.Drawing.Size(207, 129);
            this.gpboxNumb.TabIndex = 8;
            this.gpboxNumb.TabStop = false;
            this.gpboxNumb.Text = "Numero do ciclo";
            // 
            // rdbNoite3
            // 
            this.rdbNoite3.AutoSize = true;
            this.rdbNoite3.Location = new System.Drawing.Point(115, 88);
            this.rdbNoite3.Name = "rdbNoite3";
            this.rdbNoite3.Size = new System.Drawing.Size(48, 28);
            this.rdbNoite3.TabIndex = 6;
            this.rdbNoite3.TabStop = true;
            this.rdbNoite3.Text = "03";
            this.rdbNoite3.UseVisualStyleBackColor = true;
            this.rdbNoite3.CheckedChanged += new System.EventHandler(this.rdbNoite3_CheckedChanged);
            // 
            // lblNoite
            // 
            this.lblNoite.AutoSize = true;
            this.lblNoite.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoite.Location = new System.Drawing.Point(115, 25);
            this.lblNoite.Name = "lblNoite";
            this.lblNoite.Size = new System.Drawing.Size(43, 17);
            this.lblNoite.TabIndex = 5;
            this.lblNoite.Text = "Noite:";
            // 
            // rdbNoite2
            // 
            this.rdbNoite2.AutoSize = true;
            this.rdbNoite2.Location = new System.Drawing.Point(115, 67);
            this.rdbNoite2.Name = "rdbNoite2";
            this.rdbNoite2.Size = new System.Drawing.Size(48, 28);
            this.rdbNoite2.TabIndex = 5;
            this.rdbNoite2.TabStop = true;
            this.rdbNoite2.Text = "02";
            this.rdbNoite2.UseVisualStyleBackColor = true;
            this.rdbNoite2.CheckedChanged += new System.EventHandler(this.rdbNoite2_CheckedChanged);
            // 
            // lblTarde
            // 
            this.lblTarde.AutoSize = true;
            this.lblTarde.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarde.Location = new System.Drawing.Point(6, 25);
            this.lblTarde.Name = "lblTarde";
            this.lblTarde.Size = new System.Drawing.Size(44, 17);
            this.lblTarde.TabIndex = 4;
            this.lblTarde.Text = "Tarde:";
            // 
            // rdbNoite1
            // 
            this.rdbNoite1.AutoSize = true;
            this.rdbNoite1.Location = new System.Drawing.Point(115, 45);
            this.rdbNoite1.Name = "rdbNoite1";
            this.rdbNoite1.Size = new System.Drawing.Size(48, 28);
            this.rdbNoite1.TabIndex = 4;
            this.rdbNoite1.TabStop = true;
            this.rdbNoite1.Text = "01";
            this.rdbNoite1.UseVisualStyleBackColor = true;
            this.rdbNoite1.CheckedChanged += new System.EventHandler(this.rdbNoite1_CheckedChanged);
            // 
            // rdbTarde1
            // 
            this.rdbTarde1.AutoSize = true;
            this.rdbTarde1.Location = new System.Drawing.Point(6, 45);
            this.rdbTarde1.Name = "rdbTarde1";
            this.rdbTarde1.Size = new System.Drawing.Size(48, 28);
            this.rdbTarde1.TabIndex = 2;
            this.rdbTarde1.TabStop = true;
            this.rdbTarde1.Text = "01";
            this.rdbTarde1.UseVisualStyleBackColor = true;
            this.rdbTarde1.CheckedChanged += new System.EventHandler(this.rdbTarde1_CheckedChanged);
            // 
            // rdbTarde2
            // 
            this.rdbTarde2.AutoSize = true;
            this.rdbTarde2.Location = new System.Drawing.Point(6, 67);
            this.rdbTarde2.Name = "rdbTarde2";
            this.rdbTarde2.Size = new System.Drawing.Size(48, 28);
            this.rdbTarde2.TabIndex = 3;
            this.rdbTarde2.TabStop = true;
            this.rdbTarde2.Text = "02";
            this.rdbTarde2.UseVisualStyleBackColor = true;
            this.rdbTarde2.CheckedChanged += new System.EventHandler(this.rdbTarde2_CheckedChanged);
            // 
            // gpboxTurno
            // 
            this.gpboxTurno.Controls.Add(this.rdbMadrugada);
            this.gpboxTurno.Controls.Add(this.rdbNoite);
            this.gpboxTurno.Controls.Add(this.rdbTarde);
            this.gpboxTurno.Controls.Add(this.rdbManha);
            this.gpboxTurno.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpboxTurno.Location = new System.Drawing.Point(3, 297);
            this.gpboxTurno.Name = "gpboxTurno";
            this.gpboxTurno.Size = new System.Drawing.Size(311, 100);
            this.gpboxTurno.TabIndex = 7;
            this.gpboxTurno.TabStop = false;
            this.gpboxTurno.Text = "Turno";
            // 
            // rdbMadrugada
            // 
            this.rdbMadrugada.AutoSize = true;
            this.rdbMadrugada.Location = new System.Drawing.Point(92, 66);
            this.rdbMadrugada.Name = "rdbMadrugada";
            this.rdbMadrugada.Size = new System.Drawing.Size(122, 28);
            this.rdbMadrugada.TabIndex = 3;
            this.rdbMadrugada.TabStop = true;
            this.rdbMadrugada.Text = "Madrugada";
            this.rdbMadrugada.UseVisualStyleBackColor = true;
            this.rdbMadrugada.CheckedChanged += new System.EventHandler(this.rdbMadrugada_CheckedChanged);
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(214, 32);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(74, 28);
            this.rdbNoite.TabIndex = 2;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            this.rdbNoite.CheckedChanged += new System.EventHandler(this.rdbNoite_CheckedChanged);
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(115, 32);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(78, 28);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            this.rdbTarde.CheckedChanged += new System.EventHandler(this.rdbTarde_CheckedChanged);
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(16, 32);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(84, 28);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // btnCriarCabecario
            // 
            this.btnCriarCabecario.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCriarCabecario.Location = new System.Drawing.Point(95, 242);
            this.btnCriarCabecario.Name = "btnCriarCabecario";
            this.btnCriarCabecario.Size = new System.Drawing.Size(101, 35);
            this.btnCriarCabecario.TabIndex = 6;
            this.btnCriarCabecario.Text = "Criar cabeçario";
            this.btnCriarCabecario.UseVisualStyleBackColor = true;
            this.btnCriarCabecario.Click += new System.EventHandler(this.btnCriarCabecario_Click);
            // 
            // txBoxAuxLista
            // 
            this.txBoxAuxLista.Location = new System.Drawing.Point(34, 197);
            this.txBoxAuxLista.Name = "txBoxAuxLista";
            this.txBoxAuxLista.Size = new System.Drawing.Size(219, 23);
            this.txBoxAuxLista.TabIndex = 5;
            // 
            // txBoxCoComando
            // 
            this.txBoxCoComando.Location = new System.Drawing.Point(34, 139);
            this.txBoxCoComando.Name = "txBoxCoComando";
            this.txBoxCoComando.Size = new System.Drawing.Size(219, 23);
            this.txBoxCoComando.TabIndex = 4;
            // 
            // txBoxComando
            // 
            this.txBoxComando.Location = new System.Drawing.Point(34, 82);
            this.txBoxComando.Name = "txBoxComando";
            this.txBoxComando.Size = new System.Drawing.Size(219, 23);
            this.txBoxComando.TabIndex = 3;
            // 
            // lblAuxiliar
            // 
            this.lblAuxiliar.AutoSize = true;
            this.lblAuxiliar.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuxiliar.Location = new System.Drawing.Point(19, 170);
            this.lblAuxiliar.Name = "lblAuxiliar";
            this.lblAuxiliar.Size = new System.Drawing.Size(148, 24);
            this.lblAuxiliar.TabIndex = 2;
            this.lblAuxiliar.Text = "Auxiliar de lista:";
            // 
            // lblCocomando
            // 
            this.lblCocomando.AutoSize = true;
            this.lblCocomando.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCocomando.Location = new System.Drawing.Point(19, 108);
            this.lblCocomando.Name = "lblCocomando";
            this.lblCocomando.Size = new System.Drawing.Size(146, 24);
            this.lblCocomando.TabIndex = 1;
            this.lblCocomando.Text = "Co.Comandante:";
            // 
            // lblComandante
            // 
            this.lblComandante.AutoSize = true;
            this.lblComandante.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComandante.Location = new System.Drawing.Point(19, 55);
            this.lblComandante.Name = "lblComandante";
            this.lblComandante.Size = new System.Drawing.Size(118, 24);
            this.lblComandante.TabIndex = 0;
            this.lblComandante.Text = "Comandante:";
            // 
            // pnDefinicao
            // 
            this.pnDefinicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDefinicao.Controls.Add(this.btnConcluir);
            this.pnDefinicao.Controls.Add(this.btnListar);
            this.pnDefinicao.Controls.Add(this.txboxCorpoList);
            this.pnDefinicao.Controls.Add(this.txboxPreVisual);
            this.pnDefinicao.Controls.Add(this.txBoxAliadaVisi);
            this.pnDefinicao.Controls.Add(this.txBoxName);
            this.pnDefinicao.Controls.Add(this.label4);
            this.pnDefinicao.Controls.Add(this.label3);
            this.pnDefinicao.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnDefinicao.Location = new System.Drawing.Point(375, 12);
            this.pnDefinicao.Name = "pnDefinicao";
            this.pnDefinicao.Size = new System.Drawing.Size(545, 542);
            this.pnDefinicao.TabIndex = 1;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(266, 463);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(99, 35);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(54, 463);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 35);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txboxCorpoList
            // 
            this.txboxCorpoList.Location = new System.Drawing.Point(250, 3);
            this.txboxCorpoList.Multiline = true;
            this.txboxCorpoList.Name = "txboxCorpoList";
            this.txboxCorpoList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txboxCorpoList.Size = new System.Drawing.Size(278, 423);
            this.txboxCorpoList.TabIndex = 7;
            // 
            // txboxPreVisual
            // 
            this.txboxPreVisual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txboxPreVisual.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txboxPreVisual.Location = new System.Drawing.Point(3, 195);
            this.txboxPreVisual.Multiline = true;
            this.txboxPreVisual.Name = "txboxPreVisual";
            this.txboxPreVisual.ReadOnly = true;
            this.txboxPreVisual.Size = new System.Drawing.Size(241, 132);
            this.txboxPreVisual.TabIndex = 6;
            // 
            // txBoxAliadaVisi
            // 
            this.txBoxAliadaVisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxAliadaVisi.Location = new System.Drawing.Point(20, 145);
            this.txBoxAliadaVisi.Name = "txBoxAliadaVisi";
            this.txBoxAliadaVisi.Size = new System.Drawing.Size(224, 20);
            this.txBoxAliadaVisi.TabIndex = 5;
            // 
            // txBoxName
            // 
            this.txBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBoxName.Location = new System.Drawing.Point(20, 86);
            this.txBoxName.Name = "txBoxName";
            this.txBoxName.Size = new System.Drawing.Size(162, 20);
            this.txBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aliadas visitadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nick:";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerar.Location = new System.Drawing.Point(353, 585);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(99, 35);
            this.btnGerar.TabIndex = 10;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_S.A.L__PRO_.Properties.Resources.WhatsApp_Image_2022_01_25_at_20_22_28_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(821, 560);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(930, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.pnDefinicao);
            this.Controls.Add(this.pnCriacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaprincipal";
            this.Text = "Sistema automático de lista";
            this.pnCriacao.ResumeLayout(false);
            this.pnCriacao.PerformLayout();
            this.gpboxNumb.ResumeLayout(false);
            this.gpboxNumb.PerformLayout();
            this.gpboxTurno.ResumeLayout(false);
            this.gpboxTurno.PerformLayout();
            this.pnDefinicao.ResumeLayout(false);
            this.pnDefinicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCriacao;
        private System.Windows.Forms.GroupBox gpboxNumb;
        private System.Windows.Forms.RadioButton rdbNoite3;
        private System.Windows.Forms.Label lblNoite;
        private System.Windows.Forms.RadioButton rdbNoite2;
        private System.Windows.Forms.Label lblTarde;
        private System.Windows.Forms.RadioButton rdbNoite1;
        private System.Windows.Forms.RadioButton rdbTarde1;
        private System.Windows.Forms.RadioButton rdbTarde2;
        private System.Windows.Forms.GroupBox gpboxTurno;
        private System.Windows.Forms.RadioButton rdbMadrugada;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.Button btnCriarCabecario;
        private System.Windows.Forms.TextBox txBoxAuxLista;
        private System.Windows.Forms.TextBox txBoxCoComando;
        private System.Windows.Forms.TextBox txBoxComando;
        private System.Windows.Forms.Label lblAuxiliar;
        private System.Windows.Forms.Label lblCocomando;
        private System.Windows.Forms.Label lblComandante;
        private System.Windows.Forms.Panel pnDefinicao;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txboxCorpoList;
        private System.Windows.Forms.TextBox txboxPreVisual;
        private System.Windows.Forms.TextBox txBoxAliadaVisi;
        private System.Windows.Forms.TextBox txBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}