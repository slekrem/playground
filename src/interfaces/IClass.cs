namespace playground
{
    public interface IClass
    {
        INamespace string Namespace { get; }
        
        IEnumerable<IUsing> Usings { get; }
        
        IAccessModifier AccessModifier { get; }
        
        bool IsAbstarct { get; }
        
        string Name { get; }
        
        IClass BaseType { get; }
        
        IEnumerable<IInterface> Interfaces { get; }
        
        IEnumerable<IMember> Members { get; }
        
        IEnumerable<IProperty> Properties { get; }
        
        IEnumerable<IConstructor> Constructor { get; }
        
        IEnumerable<Func<T>> Functions { get; }
        
        IEnumerable<Action<T>> Actions { get; }
    }
}
