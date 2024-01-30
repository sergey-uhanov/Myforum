using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Myforum.Data;
using Myforum.Model;

namespace Myforum.Pages.Topic
{
    public class NewTopicModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ListDescriptionType _listDescriptionType;
        public List<string> TypeList { get; set; }
        public NewTopicModel(ApplicationDbContext context, ListDescriptionType listDescriptionType)
        {
            _context = context;
            _listDescriptionType = listDescriptionType;
            TypeList = _listDescriptionType.listType;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Myforum.Model.Topic Topic { get; set; } = new Myforum.Model.Topic();

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Topics.Add(Topic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./SuccessfullySubmitted");
        }
    }
}
