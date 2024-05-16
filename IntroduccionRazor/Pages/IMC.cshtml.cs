using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
    public class IMCModel : PageModel
    {
        //Definición de variables
        [BindProperty]
        public float peso { get; set; }

        [BindProperty]
        public float estatura { get; set; }

        public float Resultado { get; set; }

        public void OnPost()
        {
            float pesoEnviar = peso;
            float estaturaEnviar = estatura;

            Resultado = peso / (estaturaEnviar * estaturaEnviar);

            ModelState.Clear(); 
        }

        public void OnGet()
        {
        }
    }
}
