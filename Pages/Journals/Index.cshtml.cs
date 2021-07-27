using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Journal.Model;
using Journals.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Journal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

      

        public IEnumerable<JournalModel> JournalList { get; set; }
        //Get all journals
        public async Task OnGet()
        {
            JournalList = await _db.JournalList.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var journalFromDb = await _db.JournalList.FindAsync(id);
            if(journalFromDb == null)
            {
                return NotFound();
            }
            else
            {
                _db.Remove(journalFromDb);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
        }
    }
}
