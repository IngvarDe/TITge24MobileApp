using CommunityToolkit.Mvvm.ComponentModel;
using MauiCRUD.Data;
using MauiCRUD.Models;
using System.Collections.ObjectModel;


namespace MauiCRUD.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        private readonly DatabaseContext _context;

        public ProductsViewModel(DatabaseContext context)
        {
            _context = context;
        }

        [ObservableProperty]
        private ObservableCollection<Product> _products = new();

        [ObservableProperty]
        private Product _operatingProduct = new();

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _busyText;
    }
}
