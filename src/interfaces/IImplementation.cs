namespace playground.interfaces
{
    public interface IImplementation
    {
        INamespace Namespace { get; }
        
        IEnumerable<IUsing> Usings { get; }
        
        IClass Class { get; }
    }
}
