using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pryPereiroSP1AutoCor
{

    internal class Archivo
    {
        public string NombreArchivo { get; set; }
        public bool GrabarRepuesto(Repuesto repuesto)
        {
            // recibe un objeto de tipo Repuesto y lo graba en el archivo
            bool resultado = false;
            if (NombreArchivo != "")
            {
                // crea el stream en modo append
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                // graba la linea con los valores de los campos
                sw.WriteLine(repuesto.Codigo + "," +
                repuesto.Nombre + "," +
                repuesto.Marca + "," +
                repuesto.Precio.ToString("#.00", CultureInfo.InvariantCulture) +
                "," +
                repuesto.Origen);
                sw.Close(); // cerrar el stream
                sw.Dispose(); // liberar los recursos
                resultado = true;
            }
            return resultado;

        }
        public bool BuscarCodigoRepuesto(string codigo)
        {
            bool resultado = false;
            string Linea;
            string CodigoRepuesto;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea completa
                    CodigoRepuesto = Linea.Split(',')[0];
                    if (codigo == CodigoRepuesto)
                    {
                        resultado = true;
                        break; 
                    }
                }
                sr.Close(); 
                sr.Dispose(); 
            }
            return resultado;
        }
        public List<Repuesto> ObtenerRepuestos()
        {
            List<Repuesto> Lista = new List<Repuesto>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                        Repuesto repuesto = new Repuesto();
                    repuesto.Codigo = Linea.Split(',')[0];
                    repuesto.Nombre = Linea.Split(',')[1];
                    repuesto.Marca = Linea.Split(',')[2];
                    // el valor decimal se formatea sin formatos regionales
                    // para mantener el punto como separador decimal
                    repuesto.Precio = decimal.Parse(Linea.Split(',')[3],
                    CultureInfo.InvariantCulture);
                    repuesto.Origen = Linea.Split(',')[4];
                    Lista.Add(repuesto); // se agrega el repuesto a la lista
                }
                sr.Close(); // cerrar
                sr.Dispose(); // liberar recursos
            }
            // devuelve la lista de repuestos completa
            return Lista;

        }
        public List<Repuesto> ObtenerRepuestosOrdenados()
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos 'Repuesto'
            List<Repuesto> Lista = ObtenerRepuestos();
            // convertir la lista en un arreglo con el método "ToArray()"
            Repuesto[] repuestosArray = Lista.ToArray();
            // ordenar el arreglo con el método de Burbuja
            // por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < repuestosArray.Length - 1; i++)
            {
                for (int j = 0; j < repuestosArray.Length - 1; j++)
                {
                    // se comparan los nombres de los repuestos
                    // usando el método 'Compare' de la clase string
                    if (string.Compare(repuestosArray[j].Nombre,
                    repuestosArray[j + 1].Nombre) > 0)
                    {
                        // se intercambian si el nombre en j es mayor al nombre en j+1
                        Repuesto aux = repuestosArray[j];
                        repuestosArray[j] = repuestosArray[j + 1];
                        repuestosArray[j + 1] = aux;
                    }
                }
            }
            // convertir el arreglo ya ordenado en una lista
            List<Repuesto> Ordenados = repuestosArray.ToList<Repuesto>();
            // devuelve la lista de respuestos ordenada por nombre en forma ascendente
            return Ordenados;

        }
    }
}
