namespace playground.interfaces
{
    // public type PropertyName { get; set; } = 
    public interface IProperty
    {
        IAccessModifier PropertyAccessModifier { get; }
        
        IType PropertyType { get; }
        
        string PropertyName { get; }
        
        IPropertyGetter Getter { get; }
        
        IPropertySetter Setter { get; }
    }
}
