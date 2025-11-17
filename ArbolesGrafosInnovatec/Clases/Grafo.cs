using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGrafosInnovatec.Clases
{
    public class Grafo
    {
        // Clase interna para manejo de prioridades en Dijkstra
        public class NodoPrioridad : IComparable<NodoPrioridad>
        {
            public int Distancia { get; set; }
            public string Nombre { get; set; }

            public NodoPrioridad(int distancia, string nombre)
            {
                Distancia = distancia;
                Nombre = nombre;
            }

            public int CompareTo(NodoPrioridad other)
            {
                int cmp = Distancia.CompareTo(other.Distancia);
                return cmp != 0 ? cmp : Nombre.CompareTo(other.Nombre);
            }
        }

        // Diccionario de adyacencia
        private Dictionary<string, List<Tuple<string, int>>> ady;

        public IEnumerable<string> Nodos { get { return ady.Keys; } }

        public Grafo()
        {
            ady = new Dictionary<string, List<Tuple<string, int>>>();
        }

        public void AgregarNodo(string nombre)
        {
            if (!ady.ContainsKey(nombre))
                ady[nombre] = new List<Tuple<string, int>>();
        }

        public void AgregarArista(string a, string b, int peso)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
                return;

            AgregarNodo(a);
            AgregarNodo(b);

            if (!ady[a].Any(x => x.Item1 == b && x.Item2 == peso))
                ady[a].Add(Tuple.Create(b, peso));

            if (!ady[b].Any(x => x.Item1 == a && x.Item2 == peso))
                ady[b].Add(Tuple.Create(a, peso));
        }

        public List<Tuple<string, string, int>> GetAristas()
        {
            var lista = new List<Tuple<string, string, int>>();
            var vistos = new HashSet<string>();

            foreach (var k in ady.Keys)
            {
                foreach (var vecino in ady[k])
                {
                    string id = k + "|" + vecino.Item1;
                    string inv = vecino.Item1 + "|" + k;
                    if (!vistos.Contains(inv))
                    {
                        lista.Add(Tuple.Create(k, vecino.Item1, vecino.Item2));
                        vistos.Add(id);
                    }
                }
            }

            return lista;
        }

        public bool EsConexo()
        {
            if (ady.Count == 0) return false;

            var visitados = new HashSet<string>();
            var cola = new Queue<string>();

            string inicio = ady.Keys.First();
            cola.Enqueue(inicio);
            visitados.Add(inicio);

            while (cola.Count > 0)
            {
                string u = cola.Dequeue();
                foreach (var vecino in ady[u])
                {
                    if (!visitados.Contains(vecino.Item1))
                    {
                        visitados.Add(vecino.Item1);
                        cola.Enqueue(vecino.Item1);
                    }
                }
            }

            return visitados.Count == ady.Count;
        }

        public Tuple<List<string>, int> Dijkstra(string inicio, string fin)
        {
            if (!ady.ContainsKey(inicio) || !ady.ContainsKey(fin))
                return Tuple.Create<List<string>, int>(null, int.MaxValue);

            var dist = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();

            foreach (var nodo in ady.Keys)
                dist[nodo] = int.MaxValue;

            dist[inicio] = 0;

            var pq = new SortedSet<NodoPrioridad>();
            pq.Add(new NodoPrioridad(0, inicio));

            while (pq.Count > 0)
            {
                var actual = pq.Min;
                pq.Remove(actual);

                string u = actual.Nombre;

                if (actual.Distancia > dist[u])
                    continue;

                if (u == fin)
                    break;

                foreach (var vecino in ady[u])
                {
                    int nuevaDist = dist[u] + vecino.Item2;
                    string v = vecino.Item1;

                    if (nuevaDist < dist[v])
                    {
                        dist[v] = nuevaDist;
                        prev[v] = u;
                        pq.Add(new NodoPrioridad(dist[v], v));
                    }
                }
            }

            if (dist[fin] == int.MaxValue)
                return Tuple.Create<List<string>, int>(null, int.MaxValue);

            var ruta = new List<string>();
            string actualNodo = fin;
            while (actualNodo != inicio)
            {
                ruta.Add(actualNodo);
                actualNodo = prev[actualNodo];
            }
            ruta.Add(inicio);
            ruta.Reverse();

            return Tuple.Create(ruta, dist[fin]);
        }
    }
}
