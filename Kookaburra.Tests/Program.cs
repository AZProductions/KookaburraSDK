using System;
using Kookaburra.SDK;
using System.Threading;
using System.Collections.Generic;

namespace Kookaburra.Tests
{
    class Program
    {
        static void Main(string[] args) 
        {
            new Alert("hello world", Alert.Type.Warning());
        }   
    }
}