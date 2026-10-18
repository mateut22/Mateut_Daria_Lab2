using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mateut_Daria_Lab2.Models;

namespace Mateut_Daria_Lab2.Pages.Publishers;

public class IndexModel : PageModel
{
    private readonly Mateut_Daria_Lab2Context _context;

    public IndexModel(Mateut_Daria_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
