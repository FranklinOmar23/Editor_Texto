namespace Editor_Texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.reahacer = new System.Windows.Forms.ToolStripMenuItem();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(874, 322);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.edicionArchivo,
            this.colorLetra,
            this.formatoArchivo});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(874, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivo,
            this.abrirArchivo,
            this.guardarArchivo});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // nuevoArchivo
            // 
            this.nuevoArchivo.Name = "nuevoArchivo";
            this.nuevoArchivo.Size = new System.Drawing.Size(180, 22);
            this.nuevoArchivo.Text = "Nuevo";
            this.nuevoArchivo.Click += new System.EventHandler(this.nuevoArchivo_Click);
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivo.Text = "Abrir";
            this.abrirArchivo.Click += new System.EventHandler(this.abrirArchivo_Click);
            // 
            // guardarArchivo
            // 
            this.guardarArchivo.Name = "guardarArchivo";
            this.guardarArchivo.Size = new System.Drawing.Size(180, 22);
            this.guardarArchivo.Text = "Guardar";
            this.guardarArchivo.Click += new System.EventHandler(this.guardarArchivo_Click);
            // 
            // edicionArchivo
            // 
            this.edicionArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.reahacer,
            this.Copiar,
            this.Pegar,
            this.seleccionarTodo,
            this.eliminarTodo});
            this.edicionArchivo.Name = "edicionArchivo";
            this.edicionArchivo.Size = new System.Drawing.Size(58, 20);
            this.edicionArchivo.Text = "Edicion";
            // 
            // Atras
            // 
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(180, 22);
            this.Atras.Text = "Salir";
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // reahacer
            // 
            this.reahacer.Name = "reahacer";
            this.reahacer.Size = new System.Drawing.Size(180, 22);
            this.reahacer.Text = "Deshacer";
            this.reahacer.Click += new System.EventHandler(this.deshacer_Click);
            // 
            // Copiar
            // 
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(180, 22);
            this.Copiar.Text = "Rehacer";
            this.Copiar.Click += new System.EventHandler(this.reahacer_Click);
            // 
            // Pegar
            // 
            this.Pegar.Name = "Pegar";
            this.Pegar.Size = new System.Drawing.Size(180, 22);
            this.Pegar.Text = "Copiar";
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.Size = new System.Drawing.Size(180, 22);
            this.seleccionarTodo.Text = "Pegar";
            this.seleccionarTodo.Click += new System.EventHandler(this.seleccionarTodo_Click);
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.Size = new System.Drawing.Size(180, 22);
            this.eliminarTodo.Text = "Eliminar Todo";
            this.eliminarTodo.Click += new System.EventHandler(this.eliminarTodo_Click);
            // 
            // colorLetra
            // 
            this.colorLetra.Name = "colorLetra";
            this.colorLetra.Size = new System.Drawing.Size(48, 20);
            this.colorLetra.Text = "Color";
            this.colorLetra.Click += new System.EventHandler(this.colorLetra_Click);
            // 
            // formatoArchivo
            // 
            this.formatoArchivo.Name = "formatoArchivo";
            this.formatoArchivo.Size = new System.Drawing.Size(64, 20);
            this.formatoArchivo.Text = "Formato";
            this.formatoArchivo.Click += new System.EventHandler(this.formatoArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(874, 346);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Your Note";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nuevoArchivo;
        private ToolStripMenuItem abrirArchivo;
        private ToolStripMenuItem guardarArchivo;
        private ToolStripMenuItem edicionArchivo;
        private ToolStripMenuItem Atras;
        private ToolStripMenuItem reahacer;
        private ToolStripMenuItem Copiar;
        private ToolStripMenuItem Pegar;
        private ToolStripMenuItem seleccionarTodo;
        private ToolStripMenuItem eliminarTodo;
        private ToolStripMenuItem colorLetra;
        private ToolStripMenuItem formatoArchivo;
    }
}