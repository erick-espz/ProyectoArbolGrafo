namespace ArbolesGrafosInnovatec
{
    partial class Form1
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
            this.gbArbol = new System.Windows.Forms.GroupBox();
            this.gbGrafo = new System.Windows.Forms.GroupBox();
            this.tbPadre = new System.Windows.Forms.TextBox();
            this.tbHijo = new System.Windows.Forms.TextBox();
            this.btnInsertarNodo = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.btnNivel = new System.Windows.Forms.Button();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.tbNodoGrafo = new System.Windows.Forms.TextBox();
            this.btnAgregarNodoGrafo = new System.Windows.Forms.Button();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.lbAristas = new System.Windows.Forms.ListBox();
            this.lbNodos = new System.Windows.Forms.ListBox();
            this.btnEsConexo = new System.Windows.Forms.Button();
            this.tbInicioRuta = new System.Windows.Forms.TextBox();
            this.tbFinRuta = new System.Windows.Forms.TextBox();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarConexiones = new System.Windows.Forms.Button();
            this.gbArbol.SuspendLayout();
            this.gbGrafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbArbol
            // 
            this.gbArbol.Controls.Add(this.label4);
            this.gbArbol.Controls.Add(this.label3);
            this.gbArbol.Controls.Add(this.label2);
            this.gbArbol.Controls.Add(this.label1);
            this.gbArbol.Controls.Add(this.tvJerarquia);
            this.gbArbol.Controls.Add(this.btnNivel);
            this.gbArbol.Controls.Add(this.tbNivel);
            this.gbArbol.Controls.Add(this.btnContar);
            this.gbArbol.Controls.Add(this.btnBuscarNodo);
            this.gbArbol.Controls.Add(this.tbBuscar);
            this.gbArbol.Controls.Add(this.btnInsertarNodo);
            this.gbArbol.Controls.Add(this.tbHijo);
            this.gbArbol.Controls.Add(this.tbPadre);
            this.gbArbol.Location = new System.Drawing.Point(10, 10);
            this.gbArbol.Name = "gbArbol";
            this.gbArbol.Size = new System.Drawing.Size(490, 582);
            this.gbArbol.TabIndex = 0;
            this.gbArbol.TabStop = false;
            this.gbArbol.Text = "Arbol (Jerarquias)";
            // 
            // gbGrafo
            // 
            this.gbGrafo.Controls.Add(this.btnMostrarConexiones);
            this.gbGrafo.Controls.Add(this.label8);
            this.gbGrafo.Controls.Add(this.label7);
            this.gbGrafo.Controls.Add(this.label6);
            this.gbGrafo.Controls.Add(this.label5);
            this.gbGrafo.Controls.Add(this.btnDijkstra);
            this.gbGrafo.Controls.Add(this.tbFinRuta);
            this.gbGrafo.Controls.Add(this.tbInicioRuta);
            this.gbGrafo.Controls.Add(this.btnEsConexo);
            this.gbGrafo.Controls.Add(this.lbNodos);
            this.gbGrafo.Controls.Add(this.lbAristas);
            this.gbGrafo.Controls.Add(this.btnAgregarArista);
            this.gbGrafo.Controls.Add(this.tbPeso);
            this.gbGrafo.Controls.Add(this.tbDestino);
            this.gbGrafo.Controls.Add(this.tbOrigen);
            this.gbGrafo.Controls.Add(this.btnAgregarNodoGrafo);
            this.gbGrafo.Controls.Add(this.tbNodoGrafo);
            this.gbGrafo.Location = new System.Drawing.Point(560, 12);
            this.gbGrafo.Name = "gbGrafo";
            this.gbGrafo.Size = new System.Drawing.Size(487, 580);
            this.gbGrafo.TabIndex = 1;
            this.gbGrafo.TabStop = false;
            this.gbGrafo.Text = "Grafo (Rutas)";
            // 
            // tbPadre
            // 
            this.tbPadre.Location = new System.Drawing.Point(119, 31);
            this.tbPadre.Name = "tbPadre";
            this.tbPadre.Size = new System.Drawing.Size(152, 26);
            this.tbPadre.TabIndex = 0;
            // 
            // tbHijo
            // 
            this.tbHijo.Location = new System.Drawing.Point(119, 70);
            this.tbHijo.Name = "tbHijo";
            this.tbHijo.Size = new System.Drawing.Size(152, 26);
            this.tbHijo.TabIndex = 1;
            // 
            // btnInsertarNodo
            // 
            this.btnInsertarNodo.Location = new System.Drawing.Point(277, 31);
            this.btnInsertarNodo.Name = "btnInsertarNodo";
            this.btnInsertarNodo.Size = new System.Drawing.Size(107, 69);
            this.btnInsertarNodo.TabIndex = 2;
            this.btnInsertarNodo.Text = "Insertar";
            this.btnInsertarNodo.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(146, 126);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(203, 26);
            this.tbBuscar.TabIndex = 3;
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(355, 126);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(107, 26);
            this.btnBuscarNodo.TabIndex = 4;
            this.btnBuscarNodo.Text = "Buscar";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(390, 31);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(94, 69);
            this.btnContar.TabIndex = 5;
            this.btnContar.Text = "Contar Nodos";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // tbNivel
            // 
            this.tbNivel.Location = new System.Drawing.Point(147, 164);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(203, 26);
            this.tbNivel.TabIndex = 6;
            // 
            // btnNivel
            // 
            this.btnNivel.Location = new System.Drawing.Point(356, 164);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(106, 26);
            this.btnNivel.TabIndex = 7;
            this.btnNivel.Text = "Ver Nivel";
            this.btnNivel.UseVisualStyleBackColor = true;
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.Location = new System.Drawing.Point(17, 227);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(436, 334);
            this.tvJerarquia.TabIndex = 8;
            // 
            // tbNodoGrafo
            // 
            this.tbNodoGrafo.Location = new System.Drawing.Point(83, 29);
            this.tbNodoGrafo.Name = "tbNodoGrafo";
            this.tbNodoGrafo.Size = new System.Drawing.Size(201, 26);
            this.tbNodoGrafo.TabIndex = 0;
            // 
            // btnAgregarNodoGrafo
            // 
            this.btnAgregarNodoGrafo.Location = new System.Drawing.Point(300, 25);
            this.btnAgregarNodoGrafo.Name = "btnAgregarNodoGrafo";
            this.btnAgregarNodoGrafo.Size = new System.Drawing.Size(181, 35);
            this.btnAgregarNodoGrafo.TabIndex = 1;
            this.btnAgregarNodoGrafo.Text = "Agregar Nodo";
            this.btnAgregarNodoGrafo.UseVisualStyleBackColor = true;
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(83, 68);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(201, 26);
            this.tbOrigen.TabIndex = 2;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(83, 101);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(201, 26);
            this.tbDestino.TabIndex = 3;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(83, 133);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(201, 26);
            this.tbPeso.TabIndex = 4;
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(341, 108);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(131, 42);
            this.btnAgregarArista.TabIndex = 5;
            this.btnAgregarArista.Text = "Agregar Arista";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            // 
            // lbAristas
            // 
            this.lbAristas.FormattingEnabled = true;
            this.lbAristas.ItemHeight = 20;
            this.lbAristas.Location = new System.Drawing.Point(259, 179);
            this.lbAristas.Name = "lbAristas";
            this.lbAristas.Size = new System.Drawing.Size(213, 204);
            this.lbAristas.TabIndex = 6;
            // 
            // lbNodos
            // 
            this.lbNodos.FormattingEnabled = true;
            this.lbNodos.ItemHeight = 20;
            this.lbNodos.Location = new System.Drawing.Point(7, 179);
            this.lbNodos.Name = "lbNodos";
            this.lbNodos.Size = new System.Drawing.Size(201, 204);
            this.lbNodos.TabIndex = 7;
            // 
            // btnEsConexo
            // 
            this.btnEsConexo.Location = new System.Drawing.Point(351, 533);
            this.btnEsConexo.Name = "btnEsConexo";
            this.btnEsConexo.Size = new System.Drawing.Size(121, 41);
            this.btnEsConexo.TabIndex = 8;
            this.btnEsConexo.Text = "¿Es Conexo?";
            this.btnEsConexo.UseVisualStyleBackColor = true;
            // 
            // tbInicioRuta
            // 
            this.tbInicioRuta.Location = new System.Drawing.Point(17, 402);
            this.tbInicioRuta.Name = "tbInicioRuta";
            this.tbInicioRuta.Size = new System.Drawing.Size(191, 26);
            this.tbInicioRuta.TabIndex = 9;
            // 
            // tbFinRuta
            // 
            this.tbFinRuta.Location = new System.Drawing.Point(17, 451);
            this.tbFinRuta.Name = "tbFinRuta";
            this.tbFinRuta.Size = new System.Drawing.Size(191, 26);
            this.tbFinRuta.TabIndex = 10;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(17, 496);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(191, 47);
            this.btnDijkstra.TabIndex = 11;
            this.btnDijkstra.Text = "Ruta mas corta";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nodo Padre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nodo Hijo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre del nodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre del nodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Destino:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Peso:";
            // 
            // btnMostrarConexiones
            // 
            this.btnMostrarConexiones.Location = new System.Drawing.Point(351, 459);
            this.btnMostrarConexiones.Name = "btnMostrarConexiones";
            this.btnMostrarConexiones.Size = new System.Drawing.Size(124, 68);
            this.btnMostrarConexiones.TabIndex = 16;
            this.btnMostrarConexiones.Text = "Mostrar Conexiones";
            this.btnMostrarConexiones.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 622);
            this.Controls.Add(this.gbGrafo);
            this.Controls.Add(this.gbArbol);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.gbArbol.ResumeLayout(false);
            this.gbArbol.PerformLayout();
            this.gbGrafo.ResumeLayout(false);
            this.gbGrafo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArbol;
        private System.Windows.Forms.GroupBox gbGrafo;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnInsertarNodo;
        private System.Windows.Forms.TextBox tbHijo;
        private System.Windows.Forms.TextBox tbPadre;
        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Button btnAgregarNodoGrafo;
        private System.Windows.Forms.TextBox tbNodoGrafo;
        private System.Windows.Forms.TextBox tbInicioRuta;
        private System.Windows.Forms.Button btnEsConexo;
        private System.Windows.Forms.ListBox lbNodos;
        private System.Windows.Forms.ListBox lbAristas;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.TextBox tbFinRuta;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarConexiones;
    }
}

