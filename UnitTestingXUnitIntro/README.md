
# UnitTestingXUnitIntro 🚀

Este proyecto es un ejemplo básico de cómo implementar pruebas unitarias utilizando XUnit en C#.

## ¿Qué es XUnit? 🧪

XUnit es un framework de pruebas unitarias para .NET. Permite a los desarrolladores escribir pruebas para su código y verificar que las funcionalidades se comporten como se espera. XUnit es una herramienta poderosa para asegurar la calidad y la estabilidad del código a lo largo del tiempo, y es conocido por su simplicidad y extensibilidad.

## Estructura del Proyecto 📁

```plaintext
UnitTestingXUnitIntro/
├── UnitTestingXUnitIntro/
│ ├── EmailNotProvidedException.cs
│ ├── MailValidator.cs
├── UnitTestingXUnitIntro.Tests/
│ ├── MailValidatorShould.cs
````


- **UnitTestingXUnitIntro**: Contiene la lógica de negocio.
  - `EmailNotProvidedException.cs`: Define una excepción personalizada lanzada cuando el correo electrónico no es proporcionado.
  - `MailValidator.cs`: Contiene métodos para validar correos electrónicos y determinar si un correo es spam.

- **UnitTestingXUnitIntro.Tests**: Contiene las pruebas unitarias para el proyecto.
  - `MailValidatorShould.cs`: Pruebas unitarias para verificar la funcionalidad de `MailValidator`.

## Requisitos 🛠️

- .NET SDK
- XUnit

## Descripción General del Código 📝

### EmailNotProvidedException.cs
Define una excepción personalizada que se lanza cuando no se proporciona un correo electrónico:
- `EmailNotProvidedException`: Excepción lanzada con el mensaje "Email cannot be empty."

### MailValidator.cs
Define métodos para validar correos electrónicos y detectar spam:
- `IsValidEmail(string? email)`: Valida si un correo electrónico tiene el formato correcto.
- `IsSpam(string? email)`: Verifica si un correo electrónico proviene de un dominio conocido por ser spam.

### MailValidatorShould.cs
Contiene pruebas unitarias para los métodos en `MailValidator.cs` utilizando decoradores `[Fact]` y `[Theory]` para probar diferentes casos:
- `ValidateValidEmails()`: Verifica que los correos electrónicos válidos sean reconocidos como válidos.
- `InvalidateInvalidEmails()`: Verifica que los correos electrónicos inválidos sean reconocidos como inválidos.
- `ValidateEmail(string email, bool expected)`: Verifica múltiples casos de correos electrónicos válidos e inválidos de manera dinámica.
- `IdentifySpam(string email, string expected)`: Verifica que los correos electrónicos sean clasificados correctamente como "Spam" o "INBOX".
- `RaiseErrorWhenEmailIsEmptyInIsValidEmail()`: Verifica que se lance una excepción `EmailNotProvidedException` cuando el correo electrónico es nulo o vacío en `IsValidEmail`.
- `RaiseErrorWhenEmailIsEmptyInIsSpam()`: Verifica que se lance una excepción `EmailNotProvidedException` cuando el correo electrónico es nulo o vacío en `IsSpam`.

## Ejecución de las Pruebas 🧪

Para ejecutar las pruebas, usa el siguiente comando en la terminal:

```sh
dotnet test
```




