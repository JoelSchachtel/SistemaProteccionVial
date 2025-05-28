using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestorMotosRetenidas.Models;
using GestorMotosRetenidas.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorMotosRetenidas.Pages.Motos
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Moto> ListaMotos { get; set; }

        public async Task OnGetAsync()
        {
            ListaMotos = await _context.Motos
                .Include(m => m.Titular)
                .Include(m => m.Infractor)
                .ToListAsync();
        }
    }
}