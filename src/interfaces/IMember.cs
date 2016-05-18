namespace com.smerkel.playground.blueprint.interfaces
{
    // protected string _member;
    // private string _member = "value";
    public interface IMember
    {
        IAccessModifier MemberAccessModifier { get; }

        IType Type { get; }

        string MemberName { get; }

        ITypeValue TypeValue { get; }
    }
}
