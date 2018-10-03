using System;
using System.Collections.Generic;
using System.Text;


public interface IPeople : IBuyer
{
    string Name { get; }
    string Id { get; }
    string Birthday { get; }
}