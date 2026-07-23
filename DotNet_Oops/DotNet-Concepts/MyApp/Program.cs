using MyLibrary;

var name = args.Length > 0 ? args[0] : "Sanika";

Console.WriteLine(Greeter.Hello(name));