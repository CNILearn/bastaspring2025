using GreetingsSample;

HomeController controller = new(new HelloService());
string result = controller.Index("Katharina");
Console.WriteLine(result);
