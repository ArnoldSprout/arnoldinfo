using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace Portfolio.Pages.Shared
{
    public class DetailModel : PageModel
    {
        private readonly IProject _projectData;
        public Project Project_ { get; set; }
        //Constructor
        public DetailModel(IProject project)
        {
            _projectData = project;
        }
        public void OnGet(int projectId)
        {
            Project_ = _projectData.GetProject(projectId);
        }
    }
}
