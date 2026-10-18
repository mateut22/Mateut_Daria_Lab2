using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mateut_Daria_Lab2.Models;

namespace Mateut_Daria_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Mateut_Daria_Lab2Context _context;

    public IndexModel(Mateut_Daria_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;
    public SelectList? AuthorList { get; set; }

    [BindProperty(SupportsGet = true)]
    public int? SelectedAuthorID { get; set; }
    public async Task OnGetAsync()
    {
        AuthorList = new SelectList(_context.Authors, "ID", "FullName");

        var books = _context.Book
            .Include(b => b.Publisher)
            .Include(b => b.Author)
            .AsQueryable();

        if (SelectedAuthorID.HasValue)
        {
            books = books.Where(b => b.AuthorID == SelectedAuthorID);
        }
        Book = await books.ToListAsync();
    }
}
