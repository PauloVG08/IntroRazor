using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
    public class MensajeSecretoModel : PageModel
    {
        [BindProperty]
        public string mensajeOriginal { get; set; }

        [BindProperty]
        public int n { get; set; }

        public string mensajeCodificado { get; set; }
        public string mensajeDecodificado { get; set; }  // Agrega esta propiedad para mostrar el mensaje decodificado

        public void OnPost()
        {
            mensajeOriginal = Request.Form["mensajeOriginal"];
        }

        public void OnPostDecodificar()
        {
            mensajeCodificado = Request.Form["mensajeCodificado"]; 
            n = int.Parse(Request.Form["n"]);  

            mensajeDecodificado = DecodeMessage(mensajeCodificado, n); 
        }

        public void OnGet()
        {
            mensajeOriginal = "";
        }

        private string DecodeMessage(string mensajeCodificado, int n)
        {
            string mensajeMayusculas = mensajeCodificado.ToUpper();
            string mensajeDecodificado = "";

            for (int i = 0; i < mensajeMayusculas.Length; i++)
            {
                char letraOriginal = mensajeMayusculas[i];
                if (letraOriginal == 'U')
                {
                    letraOriginal = 'T';
                }

                if (char.IsLetter(letraOriginal))
                {
                    int posicionAbecedario = letraOriginal - 'A';
                    int nuevaPosicion = (posicionAbecedario - n + 25) % 25;
                    char letraDecodificada = (char)('A' + nuevaPosicion);
                    mensajeDecodificado += letraDecodificada;
                }
                else
                {
                    mensajeDecodificado += letraOriginal;
                }
            }

            return mensajeDecodificado;
        }
    }
}
