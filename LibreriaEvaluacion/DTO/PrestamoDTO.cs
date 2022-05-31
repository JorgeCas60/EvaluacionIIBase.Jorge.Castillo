using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    internal class PrestamoDTO
    {
        // ToDo: atributos
        private int id;
        private int monto;

        private static List<PrestamoDTO> datos = new List<PrestamoDTO>()
        {
            new PrestamoDTO() { id = 1, monto = 50000 },
            new PrestamoDTO() { id = 2, monto = 75000 },
            new PrestamoDTO() { id = 3, monto = 98888 }
        };

        // ToDo: propiedades
        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }

        // ToDo: métodos
        public static bool Add(PrestamoDTO nuevosDatos)
        {
            try
            {
                datos.Add(nuevosDatos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<PrestamoDTO> List()
        {
            return datos;
        }

        public static int Find(int id)
        {
            for (int i = 0; i < datos.Count; i++) 
            {
                if (datos[i].id == id) 
                {
                    return i; 
                }
            }

            return -1; 
        }

        public static PrestamoDTO Find(PrestamoDTO dato)
        {
            for (int i = 0; i < datos.Count; i++) 
            {
                if (datos[i].id == dato.Id) 
                {
                    return datos[i]; 
                }
            }

            return new PrestamoDTO(); 
        }

        public static bool Edit(PrestamoDTO dato, int indice)
        {
            try
            {
                
                datos[indice] = dato;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Remove(int id)
        {
            int idEncontrado = Find(id);

            if (idEncontrado >= 0) 
            {
                datos.RemoveAt(idEncontrado);
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}

    

