using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using SieveOfEratosthenes;
using FindPrimes.Services;
using FindPrimes.Models;
using FindPrimes.Base;

namespace FindPrimes.ViewModels
{
    class FindPrimesVM : BindableBase
    {
        private int _from, _to;
        private ICommand _findPrimeNumbers;
        private bool _IsPrimeButtonEnabled;
        IPrimesFinderService _primeService;
        private string _primeNumbers, _errorMessage;
        private List<int> PrimeNumberList;
        
        
        #region Bindable Properties
        public string From
        {
            get { return _from.ToString(); }
            set {
                    SetProperty(value, () => _from.ToString(), (y) => Int32.TryParse(y, out _from));
                    ErrorMessage = "";
                    PrimeNumbers = "";
                }
        }

        public string To
        {
            get { return _to.ToString(); }
            set {
                    SetProperty(value, () => _to.ToString(), (y) => Int32.TryParse(y, out _to));
                    ErrorMessage = "";
                    PrimeNumbers = "";
                }
        }

        public bool IsPrimeButtonEnabled
        {
            get
            {
                return _IsPrimeButtonEnabled;
            }
            set
            {
                SetProperty(value, () => _IsPrimeButtonEnabled, (x) => _IsPrimeButtonEnabled = x);
            }
            
        }

        public string PrimeNumbers
        {
            get
            {
                return _primeNumbers;
            }
            set
            {
                SetProperty(value, () => _primeNumbers, (x) => _primeNumbers = x);
            }
        }

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                SetProperty(value, () => _errorMessage, (x) => _errorMessage = x);
            }
        }
        #endregion

        #region Bindable Controls

        public ICommand FindPrimeNumbers
        {
            get
            {
                if(_findPrimeNumbers == null)
                {
                    return (new RelayCommand((x) => FindPrimes())); 
                }
                return _findPrimeNumbers;
            }
            set { _findPrimeNumbers = FindPrimeNumbers; }
        }

        

        #endregion

        private void EvaulateButtonIsEnabled()
        {
            FindPrimeNumbers.CanExecute(null);
            
        }

        public void FindPrimes()
        {
            if (!ValidateInput())
            {
                FillErrorMessage();
                return;
            }
            PrimeNumberList = new List<int>();
            _primeService = new PrimeNumberModel();
            PrimeNumberList = _primeService.FindPrimes(_from, _to);
            DisplayPrimes();
        }

        public void DisplayPrimes()
        {
            StringBuilder output = new StringBuilder();
            foreach (int item in PrimeNumberList)
            {
                output.Append(item.ToString() + ", ");
            }
            //output.Remove(output.Length, 1);
            PrimeNumbers = output.ToString();

        }

        private bool ValidateInput()
        {
            if (_from >= _to)
            {
                return false;
            }
            return true;
        }

        private void FillErrorMessage()
        {
            ErrorMessage = "Begin range should be less than End range";
        }


    }
}
