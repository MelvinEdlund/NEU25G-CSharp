using System.Collections.Generic;
using System.Windows;

namespace WPF_Kontroller
{
    public partial class Uppgift_6 : Window
    {
        public Uppgift_6()
        {
            InitializeComponent();

            var students = new List<Student>
            {
                new Student { FirstName = "Kalle", LastName = "Andersson", Email = "kalle@exempel.se" },
                new Student { FirstName = "Anders", LastName = "Karlsson", Email = "anders@exempel.se" },
                new Student { FirstName = "Camilla", LastName = "Johansson", Email = "camilla@exempel.se" },
                new Student { FirstName = "Johan", LastName = "Svensson", Email = "johan@exempel.se" },
                new Student { FirstName = "Mia", LastName = "Karlsson", Email = "mia@exempel.se" }
            };

            StudentList.ItemsSource = students;
        }
    }
}
