using LibreriaEvaluacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DAL
{
    internal class PrestamoDAL
    {
        
        public bool Insertar(PrestamoDTO datos)
        {
            return PrestamoDTO.Add(datos);
        }

        public bool Actualizar(PrestamoDTO dato)
        {
           
            int indice = BuscarPorId(dato);

            
            return PrestamoDTO.Edit(dato, indice);
        }

        public bool Eliminar(PrestamoDTO datos)
        {
            return false; 
        }

        public List<PrestamoDTO> Listar()
        {
            
            return PrestamoDTO.List();
        }

        public PrestamoDTO BuscarPorId(int id)
        {

            foreach (PrestamoDTO dato in PrestamoDTO.List())
            {
                if (dato.Id == id) { return dato; }
            }


            return null;


        }

        public int BuscarPorId(PrestamoDTO dato)
        {
            
            for (int i = 0; i < PrestamoDTO.List().Count; i++)
            {
                
                if (PrestamoDTO.List()[i].Id == dato.Id)
                {
                    return i; 
                }
            }
            return 0;
        }

       
      

    }
}
