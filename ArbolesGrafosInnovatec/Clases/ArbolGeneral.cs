using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGrafosInnovatec.Clases
{
    public class ArbolGeneral
    {
        public Nodo Raiz { get; private set; }
        public ArbolGeneral(string nombreRaiz) { Raiz = new Nodo(nombreRaiz); }

        public Nodo Buscar(string nombre, Nodo inicio = null)
        {
            if (inicio == null) inicio = Raiz;
            if (inicio == null) return null;
            if (inicio.Nombre == nombre) return inicio;
            foreach (var h in inicio.Hijos)
            {
                var r = Buscar(nombre, h);
                if (r != null) return r;
            }
            return null;
        }

        public bool Insertar(string padreNombre, string hijoNombre)
        {
            var padre = Buscar(padreNombre);
            if (padre == null) return false;
            padre.Hijos.Add(new Nodo(hijoNombre));
            
            return true;
        }

        public List<string> RecorrerPreorden()
        {
            var res = new List<string>();
            RecorrerPreordenInternal(Raiz, res);
            return res;
        }
        private void RecorrerPreordenInternal(Nodo n, List<string> res)
        {
            if (n == null) return;
            res.Add(n.Nombre);
            foreach (var h in n.Hijos) RecorrerPreordenInternal(h, res);
        }

        public int Contar(Nodo inicio = null)
        {
            if (inicio == null) inicio = Raiz;
            if (inicio == null) return 0;
            int total = 1;
            foreach (var h in inicio.Hijos) total += Contar(h);
            return total;
        }

        public int Nivel(string nombre) => NivelRec(Raiz, nombre, 0);
        private int NivelRec(Nodo nodo, string nombre, int nivel)
        {
            if (nodo == null) return -1;
            if (nodo.Nombre == nombre) return nivel;
            foreach (var h in nodo.Hijos)
            {
                int n = NivelRec(h, nombre, nivel + 1);
                if (n != -1) return n;
            }
            return -1;
        }




    }


}
