namespace com.smerkel.playground.blueprint.interfaces
{
    // protected string _member;
    // private string _member = "value";
    public interface IMember
    {
        IAccessModifier MemberAccessModifier { get; }

        //IType<T> Type { get; }

        string MemberName { get; }

        //ITypeValue<T> TypeValue { get; }
    }
}
