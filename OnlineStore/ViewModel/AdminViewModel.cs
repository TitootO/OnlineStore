using OnlineStore.Models;
using Shott.Model;

namespace OnlineStore.ViewModel
{
    public class AdminViewModel : NotifyProperty
    {
        public RelayCommand AddProductCommand {  get; set; }
        public RelayCommand ChangeProductCommand {  get; set; }
        public RelayCommand DeleteProductCommand {  get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }
        public OrderPickupPoint OrderPickupPoint {  get; set; }
        private string search;
        private double ratingFrom;
        private double ratingTo;
        private int costFrom;
        private int costTo;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                OnPropertyChanged();
            }
        }
        public double RatingFrom
        {
            get { return ratingFrom; }
            set
            {
                ratingFrom = value;
                OnPropertyChanged(nameof(RatingFrom));
            }
        }

        public double RatingTo
        {
            get { return ratingTo; }
            set
            {
                ratingTo = value;
                OnPropertyChanged(nameof(RatingTo));
            }
        }
        public int CostFrom
        {
            get { return costFrom; }
            set
            {
                costFrom = value;
                OnPropertyChanged(nameof(CostFrom));
            }
        }

        public int CostTo
        {
            get { return costTo; }
            set
            {
                costTo = value;
                OnPropertyChanged(nameof(CostTo));
            }
        }
    }
}
}
