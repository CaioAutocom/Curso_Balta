using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public int Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}