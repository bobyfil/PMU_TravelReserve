using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TraverReserveCL;

namespace TravelReserve.ViewModels
{
    class MainWindowViewModel : Bases.ViewModelBase
    {
        private IEnumerable<User> users;
        public IEnumerable<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                NotifyPropertyChanged();
            }
        }
        public async void getUsername()
        {
            using (var httpClient = new HttpClient())
            {
                var msg = await httpClient.GetAsync("http://localhost:51602/api/users");
                
            }
            //return "";
        }

        public MainWindowViewModel()
        {
            
        }
    }
}
