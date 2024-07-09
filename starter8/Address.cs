using System;
namespace starter8
{
	public class Address
	{
		public Address(string address_name, string address_email, string address_phone)
		{
			name = address_name;
			email = address_email;
			phone = address_phone;
		}

        private string name { set; get; }
        private string email { set; get; }
        private string phone { set; get; }

    }
}

