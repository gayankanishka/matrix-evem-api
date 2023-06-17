namespace Matrix.EveM.Domain.Common;

public abstract class EveMException : ApplicationException
{
    protected EveMException()
    {
    }
    
    protected EveMException(string message, params object[] args)
        : base(string.Format(message, args))
    {
    }
    
    protected EveMException(string message)
        : base(message)
    {
    }
    
    protected EveMException(string message, Exception innerException, params object[] args)
        : base(string.Format(message, args), innerException)
    {
    }
    
    protected EveMException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
