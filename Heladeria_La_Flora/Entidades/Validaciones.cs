using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {

        public static bool StringIsNullEmptyWhite(string str)
        {
                bool rta = false;
            try
            {

                if (String.IsNullOrEmpty(str) && String.IsNullOrWhiteSpace(str))
                {
                    rta = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Validaciones");
            }
            
            return rta;
        }

    }
}
