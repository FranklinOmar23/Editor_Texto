using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_Texto
{
    public partial class Form1 : Form
    {
        String Archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoArchivo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Archivo = null;
        }

        private void abrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrilFile = new OpenFileDialog();
            abrilFile.Filter = "Texto|*.txt";
            if(abrilFile.ShowDialog() == DialogResult.OK)
            {
                Archivo=abrilFile.FileName;
                using (StreamReader A = new StreamReader(Archivo))
                {
                    richTextBox1.Text = A.ReadToEnd();
                }
            }
        }

        private void guardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Texto|*.txt";
            if(Archivo != null)
            {
                using(StreamWriter B = new StreamWriter(Archivo))
                {
                    B.Write(richTextBox1.Text);
                }
            }
            else
            {
                if(savefile.ShowDialog() == DialogResult.OK)
                {
                    Archivo = savefile.FileName;
                    using(StreamWriter C = new StreamWriter(savefile.FileName))
                    {
                        C.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void reahacer_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void seleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorLetra_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();
            if (Color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = Color.Color;
            }
        }

        private void formatoArchivo_Click(object sender, EventArgs e)
        {
            FontDialog formato = new FontDialog();
            if (formato.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = formato.Font;
            }
        }
    }
}