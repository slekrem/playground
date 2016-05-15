namespace playground.interfaces
{
    public interface INamespace 
    {
        IEnumerable<IUsing> Usings { get; set; }
        
        IClass Class { get; set; }
    }
}
