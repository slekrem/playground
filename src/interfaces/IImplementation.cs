namespace com.smerkel.playground.blueprint.interfaces
{
    using System.Collections.Generic;

    public interface IImplementation
    {
        INamespace Namespace { get; }

        IEnumerable<IUsing> Usings { get; }

        IClass Class { get; }
    }
}
