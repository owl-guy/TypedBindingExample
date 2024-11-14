using CommunityToolkit.Maui.Markup;

namespace TypedBindingExample
{
    public partial class MainPage : ContentPage
    {
        private string _myVal;
        public string MyVal
        {
            get => _myVal;
            set
            {
                _myVal = value;
                OnPropertyChanged();
            }
        } 

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            myLabel.Bind(Label.TextProperty, (MainPage bc) => bc.MyVal);
        }
    }

}
