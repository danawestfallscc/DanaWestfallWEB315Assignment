using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheGardenRoomFlower.Models;

namespace TheGardenRoom.Pages_Flowers
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesFlowerContext _context;

        public DeleteModel(RazorPagesFlowerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Flower Flower { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flower = await _context.Flower.FirstOrDefaultAsync(m => m.Id == id);

            if (Flower == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flower = await _context.Flower.FindAsync(id);

            if (Flower != null)
            {
                _context.Flower.Remove(Flower);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
