using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica1.Vistas
{
    public partial class Logs : Form
    {
        public string directorio = "";
        public Logs()
        {
            InitializeComponent();
        }
        // Muestra todos los archivos en un TreeView
        private void Logs_Load(object sender, EventArgs e)
        {
            List<String> parentDir = new List<string>();
            parentDir.AddRange(Directory.GetFiles(directorio, "*.*"));
            foreach (String s in parentDir)
            {
                FileInfo f = new FileInfo(s);
                TreeNode subItems = new TreeNode(f.Name);
                treeView1.Nodes.Add(subItems);
            }
        }
        /* Muestra el contenido de archivo seleccionado en el TreeView
        mediante un rich text box*/
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(directorio + "/" +
            treeView1.SelectedNode.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
