namespace com.smerkel.playground.blueprint.interfaces
{
    using System.Collections.Generic;

    public interface IClass
    {
        INamespace Namespace { get; }

        IEnumerable<IUsing> Usings { get; }

        IAccessModifier AccessModifier { get; }

        bool IsAbstarct { get; }

        string Name { get; }

        IImplementation BaseType { get; }

        IEnumerable<IInterface> Interfaces { get; }

        IEnumerable<IMember> Members { get; }

        IEnumerable<IProperty> Properties { get; }

        IEnumerable<IConstructor> Constructor { get; }

        IEnumerable<IFunc> Functions { get; }

        IEnumerable<IAction> Actions { get; }
    }
}
