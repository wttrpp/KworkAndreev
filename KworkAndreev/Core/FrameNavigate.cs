using KworkAndreev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KworkAndreev.Core
{
    public class FrameNavigate
    {
        public static Frame FrameObject { get; set; }

        public static kworkDBAndreevEntities DB { get; set; }

        public static int UserID { get; set; }
    }
}
