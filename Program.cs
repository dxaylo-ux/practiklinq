using System.Text.RegularExpressions;

List<Person> people = new List<Person>
{
    new Person
    {
        Id = 1,
        Name = "Behruz",
        Age = 20,
        CityId = 1
    },

    new Person
    {
        Id = 1,
        Name = "Ali",
        Age = 25,
        CityId = 1
    },

    new Person
    {
        Id = 3,
        Name = "Muhammad",
        Age = 30,
        CityId = 1
    },

    new Person
    {
        Id = 4,
        Name = "John",
        Age = 22,
        CityId = 3
    },

    new Person
    {
        Id = 5,
        Name = "Alexander",
        Age = 35,
        CityId = 2
    },

    new Person
    {
        Id = 6,
        Name = "Elizabeth",
        Age = 28,
        CityId = 3
    }
};






List<City> cities = new List<City>
{
    new City
    {
        Id = 1,
        Name = "Dushanbe"
    },

    new City
    {
        Id = 2,
        Name = "Moscow"
    },

    new City
    {
        Id = 3,
        Name = "London"
    },

    new City
    {
        Id = 4,
        Name = "Paris"
    },

    new City
    {
        Id = 5,
        Name = "Berlin"
    },

    new City
    {
        Id = 6,
        Name = "Tokyo"
    }
};


////////////////////////////////////////////////////////////////////////////

// Task 1

// var result = people.Where(x => x.Age > 25)
// .Select(x => new
// {
//     x.Name,
//     x.Age
// });

// foreach (var p in result)
// {
//     System.Console.WriteLine($"Name : {p.Name}, Age : {p.Age}");
// }



// Task 2

// var result = people
// .OrderBy(p => p.Age)
// .ThenBy(p => p.Name);

// foreach (var person in result)
// {
//     System.Console.WriteLine($"Name : {person.Name}, Age : {person.Age}");
// }



// Task 3

// var result = people.GroupBy(x => x.Name[0]);

// foreach (var gr in result)
// {
//     System.Console.WriteLine($"Latter : {gr.Key}");


// foreach (var per in gr)
// {
//     System.Console.WriteLine($"{per.Name}");
// }

// }


// Task 4

// var result = people.Join(cities,
// person => person.CityId,
// city => city.Id,
// (person , city) => new
// {
//     PersonName = person.Name,
//     CityName = city.Name
// }

// );

// {
//     foreach (var item in result)
//     {
//         System.Console.WriteLine($"{item.PersonName} - {item.CityName}");
//     }
// }



// Task 5

// var result = people
// .Where(p => "AEIOUaeiou".Contains(p.Name[0]))
// .Sum(s => s.Age);
// System.Console.WriteLine(result);



// Task 6

// var result = people
// .GroupBy(gr => gr.Name[0])
// .Select(x => new
// {
//     Letter = x.Key,
//     Count = x.Count()
// });

// foreach (var item in result)
// {
//     System.Console.WriteLine($"{item.Letter} - {item.Count}");
// }



// Task 7

// var result = people
// .GroupBy(p => p.CityId)
// .OrderByDescending(g => g.Count())
// .First();

// Console.WriteLine(result.Key);


    
// Task 8

// var pp = people.Join(cities, p=> p.CityId, c=> c.Id, (p,c)=> new (person=p.Name, age=p.Age, city=c.Name));

// var result = pp.Where(x=> x.age > 2 && x.age < 7 && x.city.StartsWith("A"));

// foreach (var i in result)
// {
//     System.Console.WriteLine();
// }






////////////////////////////////////////////////////////////////////////////







List<Student> students = new List<Student>
{
new Student { Id = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
new Student { Id = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
new Student { Id = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};



List<Course> courses = new List<Course>
{
new Course { Id = 101, Title = "Mathematics", Credits = 4 },
new Course { Id = 102, Title = "Computer Science", Credits = 3 },
new Course { Id = 103, Title = "Physics", Credits = 4 }
};



List<Enrollment> enrollments = new List<Enrollment>
{
new Enrollment { Id = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
new Enrollment { Id = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
new Enrollment { Id = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
new Enrollment { Id = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
new Enrollment { Id = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
new Enrollment { Id = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};



// Task 1

// var result = students.Join(enrollments, s => s.Id, st => st.StudentId, (s , st) => new
// {
//     Student = s,
//     Enrollment = st
// }
// )
// .Join(courses, x=> x.Enrollment.CourseId, k => k.Id, (x , c) => new
// {
//     Student = x.Student,
//     Course = c
// }
// )
// .Where(x => x.Course.Title == "Mathematics")
// .Select(x => x.Student);

// foreach (var student in result)
// {
//     Console.WriteLine(student.Name);
// }




// Task 2

// var result = students
// .Where(s => s.Name == "Physics")
// .Join( enrollments, s => s.Id, e => e.StudentId, (s, e) => e.CourseId)
// .Join( courses, courseId => courseId, c => c.Id, (courseId, c) => c);

// foreach (var course in result)
// {
//     Console.WriteLine(course.Title);
// }



// Task 3

// var result = enrollments
// .GroupBy(e => e.StudentId)
// .Where(g => g.Count() > 1)
// .Join( students, g => g.Key, s => s.Id, (g, s) => s);

// foreach (var student in result)
// {
//     Console.WriteLine(student.Name);
// }




// Task 5


// var result = students
// .Join( enrollments, s => s.Id, e => e.StudentId, (s, e) => new
//     {
//         Student = s,
//         Enrollment = e
//     }
// )
// .Join( courses, x => x.Enrollment.CourseId, c => c.Id, (x, c) => new
// {
//     Student = x.Student,
//     Enrollment = x.Enrollment,
//     Course = c
// })
// .Where(x => x.Enrollment.EnrollmentDate >= new DateTime(2025, 1, 1) && x.Course.Credits >= 3);

// foreach (var item in result)
// {
//     Console.WriteLine(
//         $"{item.Student.Name} - {item.Course.Title}"
//     );
// }



// Task 6


// var result = students
// .Join( enrollments, s => s.Id, e => e.StudentId, (s, e) => new
// {
//     Student = s,
//     CourseId = e.CourseId
// }
// )
// .Join( courses, x => x.CourseId, c => c.Id, (x, c) => new
// {
//     StudentName = x.Student.Name,
//     Credits = c.Credits
// }
// )
// .GroupBy(x => x.StudentName)
// .Select(g => new
// {
//     StudentName = g.Key,
//     TotalCredits = g.Sum(x => x.Credits)
// });

// foreach (var item in result)
// {
//     Console.WriteLine($"{item.StudentName} - {item.TotalCredits}");
// }


// Task 7

// var result = courses
// .Join(
// enrollments,
// c => c.Id,
// e => e.CourseId,
// (c, e) => new
// {
//     CourseTitle = c.Title,
//     StudentId = e.StudentId
// }
// )
// .GroupBy(x => x.CourseTitle)
// .Select(g => new
// {
//     Course = g.Key,
//     StudentCount = g.Count()
// });

// foreach (var item in result)
// {
//     Console.WriteLine($"{item.Course} - {item.StudentCount}");
// }


// Task 8

// var bob = students
// .First(s => s.Name == "Боб");

// var result = courses
// .Where(c => !enrollments
// .Any(e => e.CourseId == c.Id && e.StudentId == bob.Id));

// foreach (var course in result)
// {
//     Console.WriteLine(course.Title);
// }

