using ProxyPattern;
using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        ISubject proxyUser = new Proxy("User");
        Console.WriteLine(proxyUser.Request("public"));
        Console.WriteLine(proxyUser.Request("public"));
        Console.WriteLine(proxyUser.Request("private"));

        ISubject proxyAdmin = new Proxy("Admin");
        Console.WriteLine(proxyAdmin.Request("public"));
        Console.WriteLine(proxyAdmin.Request("public"));
        Console.WriteLine(proxyAdmin.Request("private"));
    }
}