using Shott.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Order: NotifyProperty
    {
        int id;
        DateTime time;
        OrderPickupPoint orderPickupPoint;
        Client client;
        Employee employee;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public DateTime Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }
        public OrderPickupPoint OrderPickupPoint
        {
            get { return orderPickupPoint; }
            set
            {
                orderPickupPoint = value;
                OnPropertyChanged(nameof(OrderPickupPoint));
            }
        }

        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
                OnPropertyChanged(nameof(Client));
            }
        }

        public Employee Employee
        {
            get { return employee; }
            set
            {
                employee = value;
                OnPropertyChanged(nameof(Employee));
            }
        }
    }
}
