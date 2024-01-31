using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            string[] nomes = new string[3];
            nomes[0] = "Gabriel";
            nomes[1] = "Alex";
            nomes[2] = "Tanna";

            // lista generica
            List<string> nomes2 = new List<string>();


            nomes2.Add("Lucas");
            nomes2.Add("Roger");
            nomes2.AddRange(nomes);

            nomes2.Remove("Lucas");

            //Lista.Items.Add(nomes2[0]);
            //Lista.Items.Add(nomes2[1]);

            //Lista.Items.AddRange(nomes);

            //if (nomes2.Remove("Lucas"))
            //{
            //    MessageBox.Show("Lucas Removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel Remover.");
            //}


            //if(nomes2.Contains("Alex"))
            //{
            //    MessageBox.Show("Contém.");
            //}
            //else
            //{
            //    MessageBox.Show("Não contem.");
            //}

            // MessageBox.Show("Número de elementos: " + nomes2.Count);
            // nomes2.Sort();

            // MessageBox.Show("Alex está no indice: " + nomes2.IndexOf("Alex"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();



            foreach(string nome in nomes2)
            {
                Lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                    "Carro", 
                     "Moto",
                     "Avião",
                     "Helicoptero",
                     "Barco"
            };

            //if(veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item Adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado!");
            //}



            //if(veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("true");
            //}
            //else
            //{
            //    MessageBox.Show("false");
            //}

            //if (veiculos.Remove("Carro"))
            //{
            //    MessageBox.Show("Deu certo remover");
            //}
            //else
            //{
            //    MessageBox.Show("Não");
            //}

            //int num = veiculos.Count;
            //veiculos.Clear();


            foreach (string item in veiculos)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)

        {
            Lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 150, "Alex"},
                { 200, "Tanna" },
                {80, "Alex" }
            };

            alunos.Add(100, "Gabriel");

            foreach(KeyValuePair<int, string> item in alunos )
            {
                Lista.Items.Add(item.Key + "=" + item.Value);
            }

            //// Alunos.count;
            //alunos.Remove(1);
            //alunos.Clear();
            //alunos.ContainsKey(200);
            //alunos.ContainsValue("Alex");
            //alunos.First();
            //alunos.Last();
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Alex" },
                { 10, "Tanna" },
                { 17, "Gabriel" }
            };
            alunos.Add(15, "Gloria");

            //alunos.Reverse();
            //alunos.Remove(10);
            //  alunos.RemoveAt(0); // vai apagar o indice 0
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Alex");

            foreach(KeyValuePair<int, string> item in alunos)
            {
                Lista.Items.Add(item.Key + " " + item.Value);
            }

        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {422, "Alex" },
                {333, "Tanna" },
                {444, "Gabriel" }
            };

            alunos.Add(666, "Aluno");

            //alunos.Reverse();
            //alunos.Remove(422);
            //alunos.RemoveAt(0); // vai apagar o indice 0
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Alex");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();    
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Alex",
                "Tanna",
                "Flavio",
                "Roger"
            };

            if (!nomes.Add("Alex"))
            {
                MessageBox.Show("Não pode repetir o valor");
            }
            //nomes.Reverse(); 
            //nomes.Remove("Tanna");
            //nomes.RemoveAt(0); // vai apagar o indice 0
            ////nomes.ContainsValue("Alex");
            //MessageBox.Show(nomes.ElementAt(1));
            //MessageBox.Show(nomes.First());
            //MessageBox.Show(nomes.Last());


            foreach (string nome in nomes)
            {
                Lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Alex");
            fila.Enqueue("Roger");
            fila.Enqueue("Gabriel");

            MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila)
            {
                Lista.Items.Add(item);
            }

            //MessageBox.Show("Primeiro da fila " + fila.Peek());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila " + fila.Dequeue());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila " + fila.First());
            //MessageBox.Show(fila.Count.ToString());


            //MessageBox.Show("Primeiro da fila " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());

            //fila.Clear();

            Lista.Items.Clear();
            foreach (string item in fila)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Alex");
            pilha.Push("Tanna");
            pilha.Push("Roger");

            MessageBox.Show(pilha.Count.ToString());

            foreach(string item in pilha)
            {
                Lista.Items.Add(item);
            }

            //MessageBox.Show("Elemento no topo " + pilha.Peek());
            //MessageBox.Show(pilha.Count.ToString());
            
            //pilha.Clear

            while(pilha.Count > 0)
            {
                MessageBox.Show("Elemento no topo " + pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());

                Lista.Items.Clear();

                foreach (string item in pilha)
            {
                Lista.Items.Add(item);
            }
            }

        }
    }
}
