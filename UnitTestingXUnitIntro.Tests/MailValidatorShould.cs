


namespace UnitTestingXUnitIntro.Tests
{
    /// <summary>
    /// Clase de pruebas unitarias para verificar la funcionalidad de la clase MailValidator.
    /// Utiliza los atributos [Fact] y [Theory] para marcar métodos como pruebas unitarias que deben ser ejecutadas por el marco de pruebas xUnit.
    /// [Fact] se usa para pruebas que no necesitan parámetros.
    /// [Theory] se usa para pruebas que necesitan parámetros y se ejecutan con diferentes datos de entrada proporcionados por [InlineData].
    /// </summary>
    public class MailValidatorShould
    {
        /// <summary>
        /// Prueba que verifica que los correos electrónicos válidos sean validados correctamente.
        /// </summary>
        [Fact]
        public void ValidateValidEmails()
        {
            // Arrange
            var mailValidator = new MailValidator();
            string email = "theemailfortesting@gmail.com";

            // Act
            bool isValid = mailValidator.IsValidEmail(email);

            // Assert
            Assert.True(isValid, $"{email} is not valid");
        }

        /// <summary>
        /// Prueba que verifica que los correos electrónicos inválidos sean invalidados correctamente.
        /// </summary>
        [Fact]
        public void InvalidateInvalidEmails()
        {
            // Arrange
            var mailValidator = new MailValidator();
            string email = "theemailfortesting";

            // Act
            bool isValid = mailValidator.IsValidEmail(email);

            // Assert
            Assert.False(isValid, $"{email} is valid");
        }

        /// <summary>
        /// Prueba que verifica múltiples casos de correos electrónicos válidos e inválidos de manera dinámica.
        /// </summary>
        [Theory]
        [InlineData("theemailfortesting.gmail", false)]
        [InlineData("theemailfortesting@gmail.com", true)]
        public void ValidateEmail(string email, bool expected)
        {
            // Arrange
            var mailValidator = new MailValidator();

            // Act
            bool isValid = mailValidator.IsValidEmail(email);

            // Assert
            Assert.Equal(isValid, expected);
        }

        /// <summary>
        /// Prueba que verifica la identificación de correos electrónicos de spam.
        /// </summary>
        [Theory]
        [InlineData("spam@spam.com", "Spam")]
        [InlineData("spam@dodgy.com", "Spam")]
        [InlineData("spam@donttrust.com", "Spam")]
        [InlineData("email@email.com", "INBOX")]
        public void IdentifySpam(string email, string expected)
        {
            // Arrange  
            var mailValidator = new MailValidator();

            // Act
            string result = mailValidator.IsSpam(email);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Prueba que verifica que se lanza una excepción cuando el correo electrónico es nulo o vacío.
        /// </summary>
        [Fact]
        public void RaiseErrorWhenEmailIsEmptyInIsValidEmail()
        {
            // Arrange
            var emailValidator = new MailValidator();

            // Act y Assert
            Assert.Throws<EmailNotProvidedException>(() => emailValidator.IsValidEmail(null));
        }

        /// <summary>
        /// Prueba que verifica que se lanza una excepción cuando el correo electrónico es nulo o vacío en el método IsSpam.
        /// </summary>
        [Fact]
        public void RaiseErrorWhenEmailIsEmptyInIsSpam()
        {
            // Arrange
            var emailValidator = new MailValidator();

            // Act y Assert
            Assert.Throws<EmailNotProvidedException>(() => emailValidator.IsSpam(null));
        }
    }

}
