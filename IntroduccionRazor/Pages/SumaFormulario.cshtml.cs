using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace IntroduccionRazor.Pages
{
    public class SumaFormularioModel : PageModel
    {
        //Definimos los atributos
        [BindProperty]
        public string num1 { get; set; } = "";

        [BindProperty]
        public string num2 { get; set; } = "";

        public double suma = 0;


        public void OnPost()
        {
            double numero1 = Convert.ToDouble(num1);
            double numero2 = Convert.ToDouble(num2);

            suma = numero1 + numero2;

            ModelState.Clear();
        }

        public void OnGet()
        {
            
        }
    }
}
