using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_rysowanie_odcinków
{
    public enum LineDrawingAlgorithms
    {
        Przyrostowy,
        Wu,
    }
    public sealed class Options
    {
        private static readonly Options instance = new Options();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Options()
        {
        }

        private Options()
        {
        }


        public LineDrawingAlgorithms LineDrawingAlgorithm { get; set; } = LineDrawingAlgorithms.Przyrostowy;
        public static Options Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
