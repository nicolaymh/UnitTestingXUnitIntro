

namespace UnitTestingXUnitIntro
{
    public class EmailNotProvidedException : Exception
    {
        public override string Message => "Email cannot be empty.";
    }
}
