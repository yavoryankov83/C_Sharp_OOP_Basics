using System;
using System.Collections.Generic;
using System.Text;


public interface IPhone
{
    string Model { get; }
    string Calling(string phoneNumber);
}

