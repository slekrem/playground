namespace com.smerkel.playground.blueprint.interfaces
{
    //using System.Collections.Generic;

    public interface INamespace
    {
        IEnumerable<IUsing> Usings { get; set; }

        IImplementation Implementation { get; set; }
    }
}
