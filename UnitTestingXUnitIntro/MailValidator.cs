using System.Text.RegularExpressions;


namespace UnitTestingXUnitIntro
{
    public class MailValidator
    {
        public bool IsValidEmail(string? email)
        {
            if (string.IsNullOrEmpty(email))
                throw new EmailNotProvidedException();

            Regex regex = new(@"^[\w0-9.%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
            return regex.IsMatch(email);
        }

        public string IsSpam(string? email)
        {
            if (string.IsNullOrEmpty(email))
                throw new EmailNotProvidedException();

            List<string> spammyDomains = new() { "spam.com", "dodgy.com", "donttrust.com" };

            return spammyDomains.Any(d => email.Contains(d)) ? "Spam" : "INBOX";
        }
    }
}
