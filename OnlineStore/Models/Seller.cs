using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    class Seller: NotifyProperty
    {
        private int id;
        private string name;
        private string phone;
        private double rating;
        public int Id
        {
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public double Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }
    }
}
