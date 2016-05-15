namespace playground
{
    public interface IClass
    {
        INamespace string Namespace { get; }
        
        IEnumerable<IUsing> Usings { get; }
        
        AccessModifier AccessModifier { get; }
        
        KeyIdentifier KeyIdentifier { get; }
        
        string BaseType { get; }
        
        IEnumerable<IInterface> Interfaces { get; }
        
        IEnumerable<IMember> Members { get; }
        
        IEnumerable<IProperty> Properties { get; }
        
        IEnumerable<IConstructor> Constructor { get; }
        
        IEnumerable<Func<T>> Functions { get; }
        
        IEnumerable<Action<T>> Actions { get; }
    }
}
