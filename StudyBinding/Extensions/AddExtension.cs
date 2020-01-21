using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudyBinding
{
    [ContentProperty("Expression")]
    public class AddExtension : IMarkupExtension
    {
        public string Expression { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {

            if (!string.IsNullOrEmpty(Expression) && Expression.Contains("+"))
            {
                string[] split = Expression.Split('+');

                
                if (split.Length == 2)
                {
                    int a, b;

                    if(int.TryParse(split[0],out a) && int.TryParse(split[1],out b))
                    {
                        return a + b;
                    }
                }

            }
            return "Failed To Convert";
        }
    }
}
