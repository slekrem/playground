namespace playground.interfaces
{
    public interface INamespace 
    {
        IEnumerable<IUsing> Usings { get; set; }
        
        IImplementation Implementation { get; set; }
    }
}
