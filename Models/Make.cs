using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace aspdotnetblog.Models
{
    public class Make
    {
        //prevent no reference exception
        //Don't need to do make.Models = new Collection<Model>();
        public Make()
        {
            Models = new Collection<Model>();

        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}