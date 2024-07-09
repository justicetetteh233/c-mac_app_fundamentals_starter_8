namespace starter8;

public partial class AddressBook : ContentPage
{

	public AddressBook()
	{
		InitializeComponent();
	}

    private Address[] savedAddresses = new Address[10];
    private int totalSaved =0;

    protected void save(Address item) {
        if (totalSaved < 11) { 
        savedAddresses[totalSaved] = item;
        totalSaved = +1;

        DisplayAlert("Login Info", $"Addresses saved successfully at place {totalSaved}","OK");
        }
        else {
            DisplayAlert("Login Info", $"address was not saved successfully", "OK");
        }


    }

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string name = names.Text;
        string email = emails.Text;
        string phone = phones.Text;
        Address item = new Address(name, email, phone);
        save(item);
    }
}
