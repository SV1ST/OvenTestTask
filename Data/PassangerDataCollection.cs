using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp1.MODELS;

namespace WpfApp1.Data
{
    internal class PassangerDataCollection
    {
       
        public ObservableCollection<Passangers> passangers = new ObservableCollection<Passangers>();
        public PassangerDataCollection()
        {
            AddTestData();
        }

        public void AddTestData()
        {
            BrushConverter converter = new BrushConverter();
            passangers.Add(new Passangers { Number = "1", Character = "I", BgColor = (Brush)converter.ConvertFromString("#F4F589"), FullName = "Igor Kipernik", DepartureTime = new System.DateTime(2023, 10, 18,1,1,1), FlightNumber = "A212" });
            passangers.Add(new Passangers { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#698db8"), FullName = "Konstantin Barinov", DepartureTime = new System.DateTime(2024, 11, 3,1,1,1), FlightNumber = "B325" });
            passangers.Add(new Passangers { Number = "3", Character = "V", BgColor = (Brush)converter.ConvertFromString("#b88f69"), FullName = "Vasiliy Gorkov", DepartureTime = new System.DateTime(2023, 9, 20, 1, 1, 1), FlightNumber = "B325" });
            passangers.Add(new Passangers { Number = "4", Character = "D", BgColor = (Brush)converter.ConvertFromString("#b87269"), FullName = "Damir Kuraev", DepartureTime = new System.DateTime(2024, 11, 1, 1, 1, 1), FlightNumber = "B325" });
        }
        /*Test User*/
        
    }
}
