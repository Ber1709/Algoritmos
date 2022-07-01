using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ejercicioDeAlgoritmos
{
    public partial class Form1 : Form
    {   
        //Variables de Ejercicio 1
        private static int numero = 1;
        Libro[] libros = new Libro[numero];

        //Variables de Ejercicio 2
        Pelicula[] peliculas = new Pelicula[numero];

        //Variables de Ejercicio 3

        //Variables de Ejercicio 4
        LinkedList<string> estudiantesList = new();

        //Variables de Ejercicio 5
        Stack estudiantesCola = new();

        //Variables de Ejercicio 6
        Queue estudiantesPila = new();

        public Form1()
        {
            InitializeComponent();
       
        }

        //Metodos de ejercicio 1
        public void GuardarLibros() 
        {   
            
            for (int i = 0; i < numero; i++)
            {
                libros[i] = new Libro();
                libros[i].Titulo = txtTitulo.Text;
                libros[i].Autor = txtAutor.Text;
                libros[i].Editorial = txtEditorial.Text;
                libros[i].Ano = txtAno.Text;
                libros[i].Categoria = txtCategoria.Text;
            }

            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtAno.Text = "";
            txtCategoria.Text = "";

        }
        public void mostrarLibros()
        {            
            for (int i = 0; i < numero; i++)
            {
                txtMostrarLibros.Text = " Título: " + libros[i].Titulo + "\r"
                    + "Autor: " + libros[i].Autor + "\r" +
                    " Editorial: " + libros[i].Editorial + "\r" +
                    " Año: " + libros[i].Ano + "\r" +
                    "Categoría: " + libros[i].Categoria + "\r";
            }
        }

        private void btnGuardarE1_Click(object sender, EventArgs e)
        {
            GuardarLibros();
        }

        private void btnMostrarE1_Click(object sender, EventArgs e)
        {
            mostrarLibros();
        }

        //Metodos de Ejercicio 2
        public void GuardarPeliculas()
        {
            for (int i = 0; i < numero; i++)
            {
                peliculas[i] = new Pelicula();

                peliculas[i].Titulo = txtTitulo.Text;
                peliculas[i].Director = txtDirector.Text;
                peliculas[i].Escritor = txtEscritor.Text;
                peliculas[i].Duracion = txtDuracion.Text;
                peliculas[i].Genero = txtGenero.Text;
                peliculas[i].Productor = txtProductor.Text;
                peliculas[i].Clasificacion = txtClasificacion.Text;

            }
            txtTitulo.Text = "";
            txtDirector.Text= "";
            txtEscritor.Text= "";
            txtDuracion.Text= "";
            txtGenero.Text= "";
            txtProductor.Text= "";
            txtClasificacion.Text= "";
        }

        public void MostrarPeliculas()
        {
            for (int i = 0; i < numero; i++)
            {
                txtMostrarPeliculas.Text = "Title: " + peliculas[i].Titulo+ "\r" 
                 +"Director: "   + peliculas[i].Director + "\r"
                 +"Escritor: "   + peliculas[i].Escritor + "\r"
                 +"Duracion: "   + peliculas[i].Duracion + "\r"
                 +"Genero: "   + peliculas[i].Genero + "\r"
                 +"Procuctor: "   + peliculas[i].Productor + "\r"
                 +"Clasificacion: "   + peliculas[i].Clasificacion + "\r";
            }
        }

        public void ExportarPeliculasTxt()
        {
            for (int i = 0; i < numero; i++)
            {
                string path = @"C:\Users\berna\OneDrive\Escritorio\Semestre 9\Analisis y Optimizacion de Algoritmos";
                File.WriteAllText(path, peliculas[i].Titulo + 
                    "\r" + peliculas[i].Director + 
                    "\r" + peliculas[i].Escritor + 
                    "\r" + peliculas[i].Duracion + 
                    "\r" + peliculas[i].Genero + 
                    "\r" + peliculas[i].Productor + 
                    "\r" + peliculas[i].Clasificacion);
                MessageBox.Show("Su informacion fue exportada correctamente");
            }
        }

        private void btnGuardarPeli_Click(object sender, EventArgs e)
        {
            GuardarPeliculas();
        }

        private void btnMostrarPelis_Click(object sender, EventArgs e)
        {
            MostrarPeliculas();
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            ExportarPeliculasTxt();
        }

        //Metodos de ejercicio 3


        //Metodos de ejercicio 4
        private void agregarEstudianteLE()
        {
            estudiantesList.AddLast(txtEstudianteLE.Text);
            txtEstudianteLE.Text = "";
        }

        private void agregarUltimoLE()
        {
            estudiantesList.AddLast(txtEstudianteLE.Text);
            txtEstudianteLE.Text = "";
        }

        private void agregarPrimero()
        {
            estudiantesList.AddFirst(txtEstudianteLE.Text);
            txtEstudianteLE.Text = "";
        }
        private void mover()
        {
            string search = txtEstudianteLE.Text;
            var student = estudiantesList.Where(a => a.Contains(search));
            estudiantesList.Remove(student.FirstOrDefault());
            estudiantesList.AddLast(search);

            txtEstudianteLE.Text = "";
        }

        private void eliminar()
        {
            string search2 = txtEstudianteLE.Text = "";
            var student2 = estudiantesList.Where(a => a.Contains(search2));
            estudiantesList.Remove(student2.FirstOrDefault());
        }

        private void buscar()
        {
            string search3 = txtEstudianteLE.Text;
            if (estudiantesList.Contains(search3))
            {
                Console.WriteLine("\nEL alumno que busca SÍ existe.");
            }
            else
            {
                Console.WriteLine("\nEl alumno que busca NO existe.");
            }
        }
        
        private void cantidadEstudiantes()
        {
            foreach (var est in estudiantesList)
            {
                lbCantidadEstudiantes.Text = "Cantidad de studiantes: " + est;
            }
        }
        private void btnAgregarLE_Click(object sender, EventArgs e)
        {
            agregarEstudianteLE();
        }

        private void btnAgregarUltimoLE_Click(object sender, EventArgs e)
        {
            agregarUltimoLE();
        }

        private void btnAgregarPrimeroLE_Click(object sender, EventArgs e)
        {
            agregarPrimero();
        }

        private void btnMoverLE_Click(object sender, EventArgs e)
        {
            mover();
        }

        private void btnEliminarLE_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }


        //Metodos de ejercicio 5
        private void EmpilarEstudiante()
        {
            estudiantesCola.Push(txtEstudianteCola.Text);
            txtEstudianteCola.Text = "";
        }

        private void DesmpilarEstudiante()
        {
            estudiantesCola.Pop();
        }
        
        private void RefrescarLista()
        {
            foreach (string estudi in estudiantesCola)
            {
                listEstudiantes.Items.Remove(estudi);
            }

        }

        private void MostrarLista()
        {
            foreach (string estudi in estudiantesCola)
            {
                listEstudiantes.Items.Add(estudi);
                
            }
        }

        private void btnEmpilar_Click(object sender, EventArgs e)
        {
            EmpilarEstudiante();
        }

        private void btnDesenpilar_Click(object sender, EventArgs e)
        {
            DesmpilarEstudiante();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }


        //Metodos Ejercicio 6
        private void EmpilarEstudiantes()
        {

            estudiantesPila.Enqueue(txtEstudiantePila.Text);
            txtEstudiantePila.Text = "";
        }

        private void DesempilarEstudiantes()
        {
            estudiantesPila.Dequeue();
            txtEstudiantePila.Text = "";
        }

        private void RefrescarPila()
        {
            foreach (string est in estudiantesPila)
            {
                listPila.Items.Remove(est);
            }
        }

        private void MostrarPila()
        {
            foreach (string estudi in estudiantesPila)
            {
                listPila.Items.Add(estudi);

            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            EmpilarEstudiantes();
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            DesempilarEstudiantes();
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            MostrarPila();
        }

        private void btnRefrescarPila_Click(object sender, EventArgs e)
        {
            RefrescarPila();
        }

       
    }
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Ano { get; set; }
        public string Categoria { get; set; }
    }

    class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Escritor { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public string Productor { get; set; }
        public string Clasificacion { get; set; }
    }
}
