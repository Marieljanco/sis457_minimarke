using CadMinimarke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinimarke
{
    public class UsuarioCln
    {
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new LabMinimarkeEntities())
            {
                return context.Usuario
                    .Where(x => x.usuario == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
}
