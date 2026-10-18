using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mateut_Daria_Lab2.Models;

namespace Mateut_Daria_Lab2.Pages.AuthorsPages;

public class IndexModel : PageModel
{
    private readonly Mateut_Daria_Lab2Context _context;

    public IndexModel(Mateut_Daria_Lab2Context context)
    {
        _context = context;
    }

    public IList<Authors> Authors { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Authors = await _context.Authors.ToListAsync();
    }
}
