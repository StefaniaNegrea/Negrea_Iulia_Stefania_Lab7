using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System.Collections.ObjectModel;

namespace Negrea_Iulia_Stefania_Lab7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<StudentInfo> Students { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Inițializarea listei de studenți și adăugarea informațiilor
            Students = new ObservableCollection<StudentInfo>
            {
                new StudentInfo { Name = "Student1", Description = "Info despre Student1", ImagePath = "cale-catre-imagine-1.jpg" },
                new StudentInfo { Name = "Student2", Description = "Info despre Student2", ImagePath = "cale-catre-imagine-2.jpg" },
                // Adaugă mai mulți studenți aici
            };

            // Setarea contextului de date pentru a afișa lista de studenți
            BindingContext = this;
        }

    }
}

    public class StudentInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
    
}

