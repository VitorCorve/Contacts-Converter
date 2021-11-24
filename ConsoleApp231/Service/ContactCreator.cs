
namespace DataConverter.Service
{
    public class ContactCreator
    {
        private Contact Template;
        public Contact Create(string[] data, string phoneNumber)
        {
            Template = new Contact();

            if (data is null) return null;

            Template.ID = Contact.Count;

            if (data.Length >= 1)
            {
                Template.Lastname = data[0];
                Template.Firstname = data[1];
            }
            if (data.Length >= 2)
                Template.Middlename = data[2];
            else
                Template.Lastname = data[0];

            Template.Phone = phoneNumber;

            ValidatePhone();
            ValidateFirstName();
            ValidateLastName();
            ValidateMiddleName();

            Contact.Count++;

            return Template;
        }
        private void ValidatePhone()
        {
            if (Template.Phone.Length == 10)
                Template.Phone = "7" + Template.Phone;
            if (Template.Phone.Length == 11)
                Template.Phone = "7" + Template.Phone.Substring(1);
            else
                ErrorsHandler.Handle($"Incorrect Phone in {Template.ID} line");
        }
        private void ValidateFirstName()
        {
            if (Template.Firstname.Length < 2 || Template.Firstname.Length > 50)
                ErrorsHandler.Handle($"Incorrect Firstname in {Template.ID} line");
        }
        private void ValidateLastName()
        {
            if (Template.Lastname.Length < 2 || Template.Firstname.Length > 50)
                ErrorsHandler.Handle($"Incorrect Lastname in {Template.ID} line");
        }
        private void ValidateMiddleName()
        {
            if (Template.Middlename.Length == 0) return;

            if (Template.Middlename.Length < 2 || Template.Firstname.Length > 50)
                ErrorsHandler.Handle($"Incorrect Middlename in {Template.ID} line");
        }
    }
}
