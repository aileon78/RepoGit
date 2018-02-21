using LibroFichero.Clases;
using System;
using System.Windows.Forms;

namespace LibroFichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numLibros = 0;
        static int max = 10;
        Libro[] vecLibro = new Libro[max];
        private void limpiarcampos()
        {
            TBTitulo.Text = "";
            TBAny.Text = "";
            TBAutor.Text = "";
            TBContenido.Text = "";
            TBPaginas.Text = "";
            CBDimensiones.Text = "";
            TBPaginas.Text = "";
            TBColor.Text = "";


        }
        private void BTGuardar_Click(object sender, EventArgs e)
        {
            String titulo, autor, color, contenido, dimensiones;
            int any, paginas;

            //int max = 10;

            titulo = TBTitulo.Text;
            autor = TBAutor.Text;
            color = TBColor.Text;
            contenido = TBContenido.Text;
            dimensiones = CBDimensiones.Text;
            any = Convert.ToInt32(TBAny.Text);
            paginas = Convert.ToInt32(TBPaginas.Text);

            Libro objLibro = new Libro(titulo, any, autor, color, contenido, dimensiones, paginas);
            //Libro[] vecLibro = new Libro[max];

            vecLibro[numLibros] = objLibro;
            numLibros++;

            String texto = titulo + ";" + any + ";" + autor + ";" + color + ";" + contenido + ";" + dimensiones + ";" + paginas;

            objLibro.escriuTextFitxer(texto);
            limpiarcampos();


        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {
            //RTB1.Text = "";
            //int i;
            //for (i = 0; i < numLibros; i++)
            //{
            //    RTB1.Text = RTB1.Text +
            //        "Titulo : " + vecLibro[i].Titulo + "\n" +
            //        "Autor : " + vecLibro[i].Autor + "\n" +
            //        "Año : " + vecLibro[i].Any + "\n" +
            //        "Color : " + vecLibro[i].Color + "\n" +
            //        "Contenido : " + vecLibro[i].Contenido + "\n" +
            //        "Dimensines : " + vecLibro[i].Dimensiones + "\n" +
            //        "Páginas : " + vecLibro[i].NumPag + "\n\n";
            //}

            Libro[] vec = new Libro[max];



            //for (int i = 0; i < numLibros; i++)
            //{
            //String texto = vec[i].Titulo + ";" + Convert.ToInt16(vec[i].Any) + ";" + vec[i].Any + ";" + vec[i].Color + ";" + vec[i].Contenido + ";" + vec[i].Dimensiones + ";" + Convert.ToInt16(vec[i].NumPag);

            //}




        }
    }
}
