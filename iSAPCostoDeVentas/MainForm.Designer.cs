namespace iSAPCostoDeVentas
{
    partial class MainForm
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
            panel1 = new Panel();
            INTERFASE_COSTOS = new TabPage();
            Calendario = new TabPage();
            TabDatos = new TabControl();
            CATALOGO_MOVIMIENTOSPROD = new TabPage();
            MOVIMIENTOPRODUCTO = new TabPage();
            Sucursales = new TabPage();
            Segregado = new TabPage();
            Agrupado = new TabPage();
            SAP_GL_INTERFASE = new TabPage();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonCerrarButton = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            dataGridView6 = new DataGridView();
            dataGridView7 = new DataGridView();
            dataGridView8 = new DataGridView();
            panel1.SuspendLayout();
            INTERFASE_COSTOS.SuspendLayout();
            Calendario.SuspendLayout();
            TabDatos.SuspendLayout();
            CATALOGO_MOVIMIENTOSPROD.SuspendLayout();
            MOVIMIENTOPRODUCTO.SuspendLayout();
            Sucursales.SuspendLayout();
            Segregado.SuspendLayout();
            Agrupado.SuspendLayout();
            SAP_GL_INTERFASE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCerrarButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 36);
            panel1.TabIndex = 2;
            // 
            // INTERFASE_COSTOS
            // 
            INTERFASE_COSTOS.Controls.Add(dataGridView2);
            INTERFASE_COSTOS.Location = new Point(4, 22);
            INTERFASE_COSTOS.Name = "INTERFASE_COSTOS";
            INTERFASE_COSTOS.Padding = new Padding(3);
            INTERFASE_COSTOS.Size = new Size(846, 541);
            INTERFASE_COSTOS.TabIndex = 1;
            INTERFASE_COSTOS.Text = "INTERFASE_COSTOS";
            INTERFASE_COSTOS.UseVisualStyleBackColor = true;
            // 
            // Calendario
            // 
            Calendario.Controls.Add(dataGridView1);
            Calendario.Location = new Point(4, 22);
            Calendario.Name = "Calendario";
            Calendario.Padding = new Padding(3);
            Calendario.Size = new Size(846, 541);
            Calendario.TabIndex = 0;
            Calendario.Text = "Calendario";
            Calendario.UseVisualStyleBackColor = true;
            // 
            // TabDatos
            // 
            TabDatos.Controls.Add(Calendario);
            TabDatos.Controls.Add(INTERFASE_COSTOS);
            TabDatos.Controls.Add(CATALOGO_MOVIMIENTOSPROD);
            TabDatos.Controls.Add(MOVIMIENTOPRODUCTO);
            TabDatos.Controls.Add(Sucursales);
            TabDatos.Controls.Add(Segregado);
            TabDatos.Controls.Add(Agrupado);
            TabDatos.Controls.Add(SAP_GL_INTERFASE);
            TabDatos.Dock = DockStyle.Fill;
            TabDatos.ItemSize = new Size(64, 18);
            TabDatos.Location = new Point(0, 0);
            TabDatos.Name = "TabDatos";
            TabDatos.SelectedIndex = 0;
            TabDatos.Size = new Size(854, 567);
            TabDatos.TabIndex = 3;
            // 
            // CATALOGO_MOVIMIENTOSPROD
            // 
            CATALOGO_MOVIMIENTOSPROD.Controls.Add(dataGridView3);
            CATALOGO_MOVIMIENTOSPROD.Location = new Point(4, 22);
            CATALOGO_MOVIMIENTOSPROD.Name = "CATALOGO_MOVIMIENTOSPROD";
            CATALOGO_MOVIMIENTOSPROD.Size = new Size(846, 541);
            CATALOGO_MOVIMIENTOSPROD.TabIndex = 2;
            CATALOGO_MOVIMIENTOSPROD.Text = "CATALOGO_MOVIMIENTOSPROD";
            CATALOGO_MOVIMIENTOSPROD.UseVisualStyleBackColor = true;
            // 
            // MOVIMIENTOPRODUCTO
            // 
            MOVIMIENTOPRODUCTO.Controls.Add(dataGridView4);
            MOVIMIENTOPRODUCTO.Location = new Point(4, 22);
            MOVIMIENTOPRODUCTO.Name = "MOVIMIENTOPRODUCTO";
            MOVIMIENTOPRODUCTO.Size = new Size(846, 541);
            MOVIMIENTOPRODUCTO.TabIndex = 3;
            MOVIMIENTOPRODUCTO.Text = "MOVIMIENTOPRODUCTO";
            MOVIMIENTOPRODUCTO.UseVisualStyleBackColor = true;
            // 
            // Sucursales
            // 
            Sucursales.Controls.Add(dataGridView5);
            Sucursales.Location = new Point(4, 22);
            Sucursales.Name = "Sucursales";
            Sucursales.Size = new Size(846, 541);
            Sucursales.TabIndex = 4;
            Sucursales.Text = "Sucursales Pais";
            Sucursales.UseVisualStyleBackColor = true;
            // 
            // Segregado
            // 
            Segregado.Controls.Add(dataGridView6);
            Segregado.Location = new Point(4, 22);
            Segregado.Name = "Segregado";
            Segregado.Size = new Size(846, 541);
            Segregado.TabIndex = 5;
            Segregado.Text = "Segregado";
            Segregado.UseVisualStyleBackColor = true;
            // 
            // Agrupado
            // 
            Agrupado.Controls.Add(dataGridView7);
            Agrupado.Location = new Point(4, 22);
            Agrupado.Name = "Agrupado";
            Agrupado.Size = new Size(846, 541);
            Agrupado.TabIndex = 6;
            Agrupado.Text = "Agrupado";
            Agrupado.UseVisualStyleBackColor = true;
            // 
            // SAP_GL_INTERFASE
            // 
            SAP_GL_INTERFASE.Controls.Add(dataGridView8);
            SAP_GL_INTERFASE.Location = new Point(4, 22);
            SAP_GL_INTERFASE.Name = "SAP_GL_INTERFASE";
            SAP_GL_INTERFASE.Size = new Size(846, 541);
            SAP_GL_INTERFASE.TabIndex = 7;
            SAP_GL_INTERFASE.Text = "SAP_GL_INTERFASE";
            SAP_GL_INTERFASE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 535);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "total movimientos:";
            // 
            // buttonCerrarButton
            // 
            buttonCerrarButton.Location = new Point(734, 8);
            buttonCerrarButton.Name = "buttonCerrarButton";
            buttonCerrarButton.Size = new Size(75, 23);
            buttonCerrarButton.TabIndex = 1;
            buttonCerrarButton.Text = "Cerrar";
            buttonCerrarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(840, 535);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(846, 541);
            dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(846, 541);
            dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Dock = DockStyle.Fill;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(846, 541);
            dataGridView5.TabIndex = 0;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Dock = DockStyle.Fill;
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(846, 541);
            dataGridView6.TabIndex = 0;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Dock = DockStyle.Fill;
            dataGridView7.Location = new Point(0, 0);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.Size = new Size(846, 541);
            dataGridView7.TabIndex = 0;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Dock = DockStyle.Fill;
            dataGridView8.Location = new Point(0, 0);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.Size = new Size(846, 541);
            dataGridView8.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 603);
            Controls.Add(TabDatos);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Datos de trabajo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            INTERFASE_COSTOS.ResumeLayout(false);
            Calendario.ResumeLayout(false);
            TabDatos.ResumeLayout(false);
            CATALOGO_MOVIMIENTOSPROD.ResumeLayout(false);
            MOVIMIENTOPRODUCTO.ResumeLayout(false);
            Sucursales.ResumeLayout(false);
            Segregado.ResumeLayout(false);
            Agrupado.ResumeLayout(false);
            SAP_GL_INTERFASE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabPage INTERFASE_COSTOS;
        private TabPage Calendario;
        private TabControl TabDatos;
        private TabPage CATALOGO_MOVIMIENTOSPROD;
        private TabPage MOVIMIENTOPRODUCTO;
        private TabPage Sucursales;
        private TabPage Segregado;
        private TabPage Agrupado;
        private TabPage SAP_GL_INTERFASE;
        private Button buttonCerrarButton;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private DataGridView dataGridView8;
    }
}