internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Control Flow!!\n");
        IfElse.run();
        While.run();
        For.run();
        Switch.run();
        Enums.run();
        CommandLineArguements.run(args);
        Input.run();
    }
}