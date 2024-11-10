namespace DelMar.Entidades.Exceptions
{
    public class SinConfiguracionException : Exception
    {
        public SinConfiguracionException()
        {

        }
        public SinConfiguracionException(string message) : base(message) { }

        public SinConfiguracionException(string message, Exception inner) : base(message, inner) { }
    }
}
