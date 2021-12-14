using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using EntityFrameworkAssignment.Data;
using EntityFrameworkAssignment.Models;

namespace EntityFrameworkAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public readonly EntityFrameworkAssignmentContext db;

        public IndexModel(ILogger<IndexModel> logger, EntityFrameworkAssignmentContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        public void OnGet()
        {

        }
    }
}
