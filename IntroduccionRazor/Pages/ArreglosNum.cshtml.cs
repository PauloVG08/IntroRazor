using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
    public class ArreglosNumModel : PageModel
    {
        public int[] numeros { get; set; }
        public void OnGet()
        {
            Random random = new Random();
            numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = random.Next(0, 101);
            }
        }
    }
}
