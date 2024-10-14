namespace TareaGit
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Santiago(object sender, EventArgs e)
        {
            Navigation.PushAsync(new santiagoPage());
        }
    }

}
