using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Myforum.Data;
using Myforum.Model;
using Myforum.Services;

namespace Myforum
{
    public class IndexModel : PageModel
    {
        private readonly ListDescriptionType _listDescriptionType;

        public List<string> TypeList { get; set; }

        public IndexModel(ListDescriptionType listDescriptionType)
        {
            _listDescriptionType = listDescriptionType;
            TypeList = _listDescriptionType.listType;
        }



    }
}