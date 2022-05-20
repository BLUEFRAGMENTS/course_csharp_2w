using System;
using System.Collections.Generic;
using System.Text;

namespace CourseExampleLibrary.Topics.MVVM.List_MVVM
{
    public class AnimalItem
    {
        public AnimalItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsExtinct { get; set; }
    }
}
