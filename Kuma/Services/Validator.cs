using System.Text.RegularExpressions;

namespace Kuma.Services
{
    public class Validator
    {

        private ErrorProvider _errorProvider;

        public Validator(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        public bool ValidateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                _errorProvider.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                _errorProvider.SetError(textBox, string.Empty);
                return true;
            }
        }

        public bool ValidateEmailTextBox(TextBox textBox, string errorMessage)
        {
            if (!IsValidEmail(textBox.Text))
            {
                _errorProvider.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                _errorProvider.SetError(textBox, string.Empty);
                return true;
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
