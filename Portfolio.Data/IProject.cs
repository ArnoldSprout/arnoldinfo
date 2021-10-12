using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
   public interface IProject
    {
        IEnumerable<Project> ProjectList (string language);
        Project GetProject(int id);

    }
}
