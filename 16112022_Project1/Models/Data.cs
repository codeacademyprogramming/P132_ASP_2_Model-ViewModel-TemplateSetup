using System.Collections.Generic;

namespace _16112022_Project1.Models
{
    public static class Data
    {
        public static List<Group> Groups = new List<Group>
            {
                new Group{Id = 1,No = "P123"},
                new Group{Id = 2,No = "P124"},
                new Group{Id = 3,No = "P132"},
                new Group{Id = 4,No = "P133"},

            };

        public static List<Student> Students = new List<Student>
            {
                new Student{Id = 1,Fullname ="Hikmet",Point=45},
                new Student{Id = 2,Fullname ="Nermin",Point=65},
                new Student{Id = 3,Fullname ="Tofiq",Point=85},
            };
    }
}
