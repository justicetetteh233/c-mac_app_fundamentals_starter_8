namespace starter8;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        DisplayAlert("Login Info", $"Username: {username}\nPassword: {password}", "OK");
    }
}
