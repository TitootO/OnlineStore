using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class OrderPickupPoint: NotifyProperty
    {
        int id;
        string adress;
        double rating;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
                OnPropertyChanged(nameof(Adress));
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged(nameof(Rating));
            }
        }
    }
}
