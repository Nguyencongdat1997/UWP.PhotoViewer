using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Data
{
    public interface IPhoto
    {
        String Uri { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
