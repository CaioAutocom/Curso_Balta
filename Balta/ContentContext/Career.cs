using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
        : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public int Courses { get; set; }
        public IList<CareerItem> Items { get; set; }
        //sempre que tiver apenas o Get e não o set, e o retorno
        //for de uma linha só, podemos utilizar o => e adicionar o retorno
        public int TotalCourses => Items.Count;
        // => é chamado de Expression body
    }

}