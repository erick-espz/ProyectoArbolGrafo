using ArbolesGrafosInnovatec.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesGrafosInnovatec
{
    public partial class Form1 : Form
    {
        private ArbolGeneral arbol;
        private Grafo grafo;

        public Form1()
        {
            InitializeComponent();

            // Inicialización de estructuras 
            arbol = new ArbolGeneral("Innovatec");    // Raíz por defecto
            grafo = new Grafo();


            RefreshTreeView();
            RefreshGrafoList();
        }

        ///Parte A: Arbol/Jerarquia
     

        private void btnInsertarNodo_Click(object sender, EventArgs e)
        {
            string padre = tbPadre.Text.Trim();
            string hijo = tbHijo.Text.Trim();

            if (padre == "" || hijo == "")
            {
                MessageBox.Show("Debe ingresar padre e hijo.");
                return;
            }

            if (!arbol.Insertar(padre, hijo))
            {
                MessageBox.Show($"No existe el nodo padre '{padre}'.");
            }

            RefreshTreeView();
        }

        private void btnBuscarNodo_Click(object sender, EventArgs e)
        {
            string nombre = tbBuscar.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var nodo = arbol.Buscar(nombre);
            if (nodo == null)
                MessageBox.Show("Nodo no encontrado.");
            else
                MessageBox.Show("Nodo encontrado: " + nodo.Nombre);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = arbol.Contar();
            MessageBox.Show("Total de nodos: " + total);
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            string nombre = tbNivel.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nodo para calcular su nivel.");
                return;
            }

            int nivel = arbol.Nivel(nombre);
            if (nivel == -1)
                MessageBox.Show("El nodo no existe en el árbol.");
            else
                MessageBox.Show($"El nivel del nodo es: {nivel}");
        }

        //Actualizar el Tree View
        private void RefreshTreeView()
        {
            tvJerarquia.Nodes.Clear();

            TreeNode root = new TreeNode(arbol.Raiz.Nombre);
            BuildTree(arbol.Raiz, root);

            tvJerarquia.Nodes.Add(root);
            tvJerarquia.ExpandAll();
        }

        private void BuildTree(Nodo nodo, TreeNode treeNode)
        {
            foreach (var h in nodo.Hijos)
            {
                TreeNode child = new TreeNode(h.Nombre);
                treeNode.Nodes.Add(child);
                BuildTree(h, child);
            }
        }

        //Parte B: Grafo/Rutas

        private void btnAgregarNodoGrafo_Click(object sender, EventArgs e)
        {
            string nombre = tbNodoGrafo.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nombre para el nodo del grafo.");
                return;
            }

            grafo.AgregarNodo(nombre);
            RefreshGrafoList();
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            string a = tbOrigen.Text.Trim();
            string b = tbDestino.Text.Trim();

            if (!int.TryParse(tbPeso.Text.Trim(), out int peso))
            {
                MessageBox.Show("Peso inválido. Debe ser un número entero.");
                return;
            }

            grafo.AgregarArista(a, b, peso);
            RefreshGrafoList();
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            var aristas = grafo.GetAristas();

            string texto = "Conexiones registradas:\n\n";
            foreach (var (n1, n2, p) in aristas)
                texto += $"{n1} — {n2}  (peso {p})\n";

            MessageBox.Show(texto);
        }

        private void btnEsConexo_Click(object sender, EventArgs e)
        {
            bool conexo = grafo.EsConexo();
            MessageBox.Show(conexo ? "El grafo ES conexo" : "El grafo NO es conexo");
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            var inicio = tbInicioRuta.Text.Trim();
            var fin = tbFinRuta.Text.Trim();

            var (ruta, dist) = grafo.Dijkstra(inicio, fin);

            if (ruta == null)
            {
                MessageBox.Show("No existe ruta entre los nodos.");
                return;
            }

            string texto = $"Ruta más corta: {string.Join(" → ", ruta)}\nDistancia total: {dist}";
            MessageBox.Show(texto);
        }

        // Refrescar las list box de Grafo
        private void RefreshGrafoList()
        {
            lbNodos.Items.Clear();
            lbAristas.Items.Clear();

            foreach (var nodo in grafo.Nodos)
                lbNodos.Items.Add(nodo);

            foreach (var (a, b, p) in grafo.GetAristas())
                lbAristas.Items.Add($"{a} — {b}  (peso {p})");
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
