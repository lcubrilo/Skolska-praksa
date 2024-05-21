using System;
class CommandLineArgs {
    static void Main(string[] args) {
        Console.WriteLine("Komanda ima {0} argumenata", args.Length);
        if(args.Length > 0) {
            Console.WriteLine("Argumenti su:");
            foreach(string s in args) {
                Console.WriteLine(s);
            }
        }
    }
}