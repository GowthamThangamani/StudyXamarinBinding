using System;
using Xamarin.Forms;

namespace StudyBinding.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private int _enteredAmount = 500;

        public int EnteredAmount
        {
            get { return _enteredAmount; }
            set { _enteredAmount = value; }
        }

        public Command<string> BtnIncrement { get; private set; }

        public MainViewModel()
        {
            BtnIncrement = new Command<string>((increment) => this.btnIncrement(increment));
        }

        private void btnIncrement(string increment)
        {
            
        }
    }
}
