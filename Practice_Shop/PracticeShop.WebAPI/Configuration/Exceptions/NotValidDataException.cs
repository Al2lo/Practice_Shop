namespace PracticeShop.WebAPI.Configuration.Exceptions
{
    public class NotValidDateException : Exception
    {
        public NotValidDateException() { }

        public NotValidDateException(string message)
            : base(message) { }
    }
}
