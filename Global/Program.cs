using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://10.89.70.40/Mock/api/Central?service=WSConsultarQr";

            var result = Utilerias.HttpRequest<responseService>(url, System.Net.Http.HttpMethod.Get).Result;

            var prueba = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


            var salida = prueba.ToEncriptAES();


            Console.WriteLine(salida);
            Console.WriteLine(salida.ToDencriptAES());
            Console.ReadKey();
        }
    }

    class responseService
    {
        public string codigoOperacion { get; set; }
        public string tipoMensaje { get; set; }
    }
}
