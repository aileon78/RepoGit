using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroFichero.Clases
{ 
    [Serializable]
    class Libro
    {
        //variables
        private String titulo;
        private int any;
        private String autor;
        private String color;
        private String contenido;
        private String dimensiones;
        private int numPag;





        //constructores

        public Libro()
        {
        }

        public Libro(string titulo, int any, string autor, string color, string contenido, string dimensiones, int numPag)
        {
            this.Titulo = titulo;
            this.Any = any;
            this.Autor = autor;
            this.Color = color;
            this.Contenido = contenido;
            this.Dimensiones = dimensiones;
            this.NumPag = numPag;
        }


        //metodos

        public string Titulo { get => titulo; set => titulo = value; }
        public int Any { get => any; set => any = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Color { get => color; set => color = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string Dimensiones { get => dimensiones; set => dimensiones = value; }
        public int NumPag { get => numPag; set => numPag = value; }


        //METODO PARA ESCRIBIR DENTRO DEL FICHERO
        //los parametros son opcionales
        public void escriuTextFitxer(String text, String fitxer="fitxer/llibres.txt", bool afegir = true)
        {
            try
            {
                //Escribe el texto "text" en el fichero "fitxer" amb StreamWriter(caracter Stream)
                //Hem d'importar; using System.IO;

                StreamWriter arxiu = new StreamWriter(@fitxer, afegir);
                arxiu.Write(text);
                arxiu.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al fitxer ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //FUNCION QUE DEVUELVE VECTOR DE LIBRO, LEE EL FICHERO
        //los parametros son opcionales
        public Libro[] llegeixTextFitxer(String fitxer = "fitxer/llibres.txt")
        {
            //Hem d'importar : using System.IO;
            StreamReader arxiu = new StreamReader(fitxer); //utilizamos Stream para acceder al archivo
            String linia; //declaramos variable linia para ir guardando de linia en linia
            String[] dades = new String[7];//declaramos un vector de tamaño de las variables a guardar

            Libro[] lli = new Libro[100];//creamos un vector de 100 para ir guardando libros

            int i = 0;

            //haremos un bucle para ir metiendo libros dentro del vector
            while ((linia = arxiu.ReadLine()) != null)
            {
                //Coge una linia
                dades = linia.Split(';');//partimos por columnas, y crea el vector
                //los datos iran separados por ";"
                
            //guardamos en el objeto los diferentes campos, "i" para filas y "dades" para columnas
            lli[i]=new Libro(dades[0],Convert.ToInt32(dades[1]),dades[2],dades[3],dades[4],dades[5],Convert.ToInt32(dades[6]));

            }
            //cerramos el archivo sino no funcinará
            arxiu.Close();

            //finalmente devolvemos el libro
            return lli;


        }


    }
}
