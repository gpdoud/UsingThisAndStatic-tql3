using System.Security.Cryptography.X509Certificates;

namespace UsingTHis;

internal class Program {

    static void Main(string[] args) {

        var s1 = new Student("Jane");
        var s2 = new Student("Joe");

        Console.WriteLine($"Score of 95 is an {Student.Grade(95)}");


    }




}
