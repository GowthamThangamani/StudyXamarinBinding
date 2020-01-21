using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudyBinding.Custom
{
    public partial class CustomViewButton : ContentView
    {

        // BindableProperty implementation
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomViewButton), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public CustomViewButton()
        {
            InitializeComponent();
        }

        public static void Execute(ICommand command,object param)
        {
            if (command == null) return;
            if (command.CanExecute(param))
            {
                command.Execute(param);
            }
        }

        public void OnTap(object sender,EventArgs eventArgs)
        {
            Execute(Command, ((Label)sender).Text);
        }
    }
}
