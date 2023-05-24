using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Users
{
	[Authorize]
	public class IndexModel : PageModel
	{
		
			private readonly RostrosFelicesContext _context;

			public IndexModel(RostrosFelicesContext context)
			{
				_context = context;
			}

			public IList<User> Users { get; set; } = default!;

			public async Task OnGetAsync()
			{
				if (_context.Users != null)
				{
					Users = await _context.Users.ToListAsync();
				}
			}
	}
}

