using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseExampleLibrary.Topics.PagesTypes
{
    public class ExampleFlyoutPageFlyoutMenuItem
    {
        public ExampleFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(ExampleFlyoutPageDetail);
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}