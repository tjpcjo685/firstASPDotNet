using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zheITHome.Data;
using zheITHome.Models;

namespace zheITHome.Pages_Articles
{
    public class IndexModel : PageModel
    {
        private readonly zheITHome.Data.zheITHomeContext _context;

        public IndexModel(zheITHome.Data.zheITHomeContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
