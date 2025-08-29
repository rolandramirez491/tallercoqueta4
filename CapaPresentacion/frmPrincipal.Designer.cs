namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroYBúsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.calcularSalarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestiónDeNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroYBúsquedaToolStripMenuItem,
            this.listadoDeEmpleadosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.calcularSalarioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gestiónDeNóminaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // registroYBúsquedaToolStripMenuItem
            // 
            this.registroYBúsquedaToolStripMenuItem.Name = "registroYBúsquedaToolStripMenuItem";
            this.registroYBúsquedaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registroYBúsquedaToolStripMenuItem.Text = "&Registro y búsqueda";
            this.registroYBúsquedaToolStripMenuItem.Click += new System.EventHandler(this.registroYBúsquedaToolStripMenuItem_Click);
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "&Listado de empleados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
            // 
            // calcularSalarioToolStripMenuItem
            // 
            this.calcularSalarioToolStripMenuItem.Name = "calcularSalarioToolStripMenuItem";
            this.calcularSalarioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.calcularSalarioToolStripMenuItem.Text = "&Calcular Salario";
            this.calcularSalarioToolStripMenuItem.Click += new System.EventHandler(this.calcularSalarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // gestiónDeNóminaToolStripMenuItem
            // 
            this.gestiónDeNóminaToolStripMenuItem.Name = "gestiónDeNóminaToolStripMenuItem";
            this.gestiónDeNóminaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeNóminaToolStripMenuItem.Text = "&Gestión de Nómina";
            this.gestiónDeNóminaToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeNóminaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroYBúsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calcularSalarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

