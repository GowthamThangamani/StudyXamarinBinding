using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StudyBinding.Custom
{
    public partial class CustomText : ContentView
    {

        Button Button = new Button();

        public CustomText()
        {
            InitializeComponent();
        }       

        public static readonly BindableProperty KeyProperty = BindableProperty.Create("Key", typeof(string), typeof(CustomText), "Default Key", BindingMode.OneWay, propertyChanged: OnKeyChanged);

        public string Key
        {
            get { return (string)GetValue(KeyProperty); }
            set { SetValue(KeyProperty, value); }
        }




        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(string), typeof(CustomText), "Default Value", BindingMode.TwoWay, propertyChanged: OnValueChanged);


        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        static void OnKeyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var cc = (CustomText)bindable;
            cc.lblkey.Text = (string)newValue;
        }

        static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var cc = (CustomText)bindable;
            cc.lblvalue.Text = (string)newValue;

            cc.lblkey.Text = (string)oldValue;
        }
    }
}
