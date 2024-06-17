using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTHis;

internal class Student {

    private static int nextId { get; set; } = 1;

    public int Id { get; set; }
    public string Name { get; set; }

    public static string Grade(int score) {
        if(score >= 92) {
            return "A";
        } else if(score >= 85 && score < 92) {
            return "B";
        }
        return "?";
    }

    public Student(string Name) {
        this.Id = nextId++;
        this.Name = Name
    }
    
}
