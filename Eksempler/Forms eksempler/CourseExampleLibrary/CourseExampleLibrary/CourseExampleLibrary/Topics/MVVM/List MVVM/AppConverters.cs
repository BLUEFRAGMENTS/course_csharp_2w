using System;
using System.Collections.Generic;
using System.Text;

namespace CourseExampleLibrary.Topics.MVVM.List_MVVM
{
    public static class AppConverters
    {
        public static BoolToColorConverter BoolToColorConverter => new BoolToColorConverter();
    }
}
