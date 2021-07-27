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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public JournalModel JournalList{ get; set; }

        //Get the journalID
        public async Task OnGet(int id)
        {
            JournalList = await _db.JournalList.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var journalFromDb = await _db.JournalList.FindAsync(JournalList.Id);
                journalFromDb.EntryName = JournalList.EntryName;
                journalFromDb.Date = JournalList.Date;
                journalFromDb.Entry = JournalList.Entry;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
