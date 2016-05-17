namespace com.smerkel.playground.blueprint.interfaces
{
    public interface IProperty
    {
        IAccessModifier PropertyAccessModifier { get; }

        //IType PropertyType { get; }

        string PropertyName { get; }

        //IPropertyGetter Getter { get; }

        //IPropertySetter Setter { get; }
    }
}