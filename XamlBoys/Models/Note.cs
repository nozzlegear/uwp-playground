using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlBoys.Models
{
    public class Note
    {
        public string Title { get; set; }

        public string Text => "Lorem ipsum dolar sit amet.";
    }
}
