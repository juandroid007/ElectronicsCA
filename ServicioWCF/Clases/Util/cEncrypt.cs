using System.Security.Cryptography;
using System.Text;

namespace Clases.Util
{
    // Fecha:       23-05-2019
    // Descripción: Clase que alberga métodos relacionados con la
    //              encriptación de cadenas.
    class cEncrypt
    {
        // Fecha:       23-05-2019
        // Descripción: Función que retorna una cadena cifrada mediante un hash
        //              generado con un algoritmo MD5.
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            StringBuilder sb = new StringBuilder();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;

            stream = md5.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
    }
}
