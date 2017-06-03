using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ParserXml
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            var x = folderBrowserDialog1.ShowDialog();
            if (x != DialogResult.OK || String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                return;

            txtPath.Text = folderBrowserDialog1.SelectedPath;
        }
        /// <summary>
        /// Você vai gerar a classe nesse site -> http://xmltocsharp.azurewebsites.net/
        /// </summary>
        public class RootClass
        {
            public Person Person { get; set; }
        }
        public class Person
        {
            public string name { get; set; }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                return;

            // Ele já pega somente os arquivos .xml
            var arquivos = Directory.GetFiles(txtPath.Text, "*.xml");
            foreach (var arquivo in arquivos)
            {
                var xml = new XmlDocument();
                xml.LoadXml(File.ReadAllText(arquivo));
                var q = (Newtonsoft.Json.JsonConvert.SerializeObject(xml));
                //Classe serializada
                var ee = (Newtonsoft.Json.JsonConvert.DeserializeObject<RootClass>(q));
            }
        }
    }
}
