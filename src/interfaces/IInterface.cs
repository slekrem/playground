namespace playground.interfaces
{
    public interface IInterface
    {
        IAccessModifier AccessModifier { get; }
        
        string InterfaceName { get; }
        
        IEnumerable<IInterface> Interfaces { get; }
    }
}
