namespace playground.interfaces
{
    // protected string _member;
    // private string _member = "value";
    public interface IMember<T>
    {
        IAccessModifier MemberAccessModifier { get; }
        
        IType<T> Type { get; }
        
        string MemberName { get; }
        
        ITypeValue<T> { get; }
    }
}
