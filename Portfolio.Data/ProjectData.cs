using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
  public  class ProjectData : IProject
    {
        List<Project> _projectList;
        //Constructor
        public ProjectData()
        {
            _projectList = new List<Project>()
            {
                
                new Project{Id=1, Title = "Key Logger", Type = ProjectType.CSharp, Discription="An application for captuirng keys when a user press his/her keyboard", Link="https://www.github.com/ArnoldSprout/KeyLoggerApp"},
                new Project{Id=2, Title = "Binary to decimal", Type = ProjectType.Java, Discription="A terminal application for converting a binary number to a decimal number", Link="https://www.github.com/ArnoldSprout/BinaryToDecimal"},
                new Project{Id=3, Title = "The post", Type = ProjectType.GoLang, Discription="A user gets to post a message on the wall which will expire after a certain period.", Link="https://www.github.com/ArnoldSprout/Snippet-Project"}


            };
        }
        public IEnumerable<Project> ProjectList(string language = null) => _projectList.Where(x => string.IsNullOrEmpty(language) || x.Title.StartsWith(language)).OrderBy(x => x.Title);
        public Project GetProject(int id) => _projectList.SingleOrDefault(x => x.Id == id);
    }
}
