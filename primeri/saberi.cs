using System;
class saberi {
    static void Main(string[] args) {
        if(args.Length > 0) {
            double sum = 0.0;
            foreach(string s in args) {
                sum += double.Parse(s);
            }
            Console.WriteLine(sum);
        }
        else {
            Console.WriteLine("Nije naveden nijedan broj");
        }
    }
}