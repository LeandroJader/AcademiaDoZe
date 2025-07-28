   public class DomainException : Exception
{
    public DomainException(string message) : base(message) { }
    
    
    public DomainException(string message, Exception innerexception) : base (message,innerexception) { }
    
        
    
}

//leandro jader