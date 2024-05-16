using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
    public class ExpresionModel : PageModel
    {
        [BindProperty]
        public double a { get; set; }

        [BindProperty]
        public double b { get; set; }

        [BindProperty]
        public double x { get; set; }

        [BindProperty]
        public double y { get; set; }

        [BindProperty]
        public int n { get; set; }

        public double totalEsperado { get; set; }

        public void OnPost()
        {
            double valorA = Convert.ToDouble(a);
            double valorB = Convert.ToDouble(b);
            double valorX = Convert.ToDouble(x);
            double valorY = Convert.ToDouble(y);
            double valorN = Convert.ToDouble(n);

            double valorPrimeraParte = (valorA * valorX);
            double valorSegundaParte =  ( valorB * valorY);
            double valorParcial = valorPrimeraParte + valorSegundaParte;
            totalEsperado = valorParcial * valorParcial;
        }

        public void OnGet()
        {
        }
    }
}
