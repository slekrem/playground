namespace com.smerkel.playground.blueprint.interfaces
{
    using System.Collections.Generic;

    public interface IInterface
    {
        IAccessModifier AccessModifier { get; }

        string InterfaceName { get; }

        IEnumerable<IInterface> Interfaces { get; }
    }
}
