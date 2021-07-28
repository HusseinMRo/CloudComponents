﻿using System.Collections.Generic;

namespace AngryMonkey.Cloud.Components
{
    public partial class DateTimePicker
    {
        protected class DateTimePickerYear
        {
            public DateTimePickerYear(int year)
            {
                Year = year;
            }

            public int Year { get; set; }
            public bool IsCurrentDecade { get; set; } = false;
            public bool IsSelected { get; set; } = false;
            public string CssClasses
            {
                get
                {
                    List<string> classes = new();

                    if (IsCurrentDecade)
                        classes.Add("_current");

                    if (IsSelected)
                        classes.Add("_selected");

                    return string.Join(' ', classes);
                }
            }
        }
    }
}
