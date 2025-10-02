namespace TipTime;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void LinkGit_Clicked(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://github.com/DanielASBatista/tipTimeFinale");
    }
}