using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Portfolio.Core;
using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProject _iproject;

        public IEnumerable<Project> Project_ { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IProject project)
        {
            _logger = logger;
            _iproject = project;
         }
        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }
        public void OnGet()
        {
            Project_ = _iproject.ProjectList(SearchQuery);

        }
    }
}
