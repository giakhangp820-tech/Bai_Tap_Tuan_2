
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Age = 16 },
            new Student { Id = 2, Name = "Binh", Age = 14 },
            new Student { Id = 3, Name = "Anh", Age = 18 },
            new Student { Id = 4, Name = "Dung", Age = 17 },
            new Student { Id = 5, Name = "Hoa", Age = 20 }
        };

        
        Console.WriteLine("Cau a: Danh sach toan bo hoc sinh");

        var danhSach = students;

        foreach (var student in danhSach)
        {
            Console.WriteLine(
                $"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"
            );
        }

        Console.WriteLine("\nCau b: Hoc sinh co tuoi tu 15 den 18");

        var hocSinhTu15Den18 = students.Where(
            s => s.Age >= 15 && s.Age <= 18
        );

        foreach (var student in hocSinhTu15Den18)
        {
            Console.WriteLine(
                $"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"
            );
        }

        
        Console.WriteLine("\nCau c: Hoc sinh co ten bat dau bang chu A");

        var hocSinhTenA = students.Where(
            s => s.Name.StartsWith("A")
        );

        foreach (var student in hocSinhTenA)
        {
            Console.WriteLine(
                $"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"
            );
        }

        
        Console.WriteLine("\nCau d: Tong tuoi cua tat ca hoc sinh");

        int tongTuoi = students.Sum(s => s.Age);

        Console.WriteLine("Tong tuoi: " + tongTuoi);

        
        Console.WriteLine("\nCau e: Hoc sinh co tuoi lon nhat");

        var hocSinhLonNhat = students
            .OrderByDescending(s => s.Age)
            .First();

        Console.WriteLine(
            $"Id: {hocSinhLonNhat.Id}, Name: {hocSinhLonNhat.Name}, Age: {hocSinhLonNhat.Age}"
        );

        
        Console.WriteLine("\nCau f: Danh sach hoc sinh sap xep theo tuoi tang dan");

        var danhSachSapXep = students.OrderBy(s => s.Age);

        foreach (var student in danhSachSapXep)
        {
            Console.WriteLine(
                $"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}"
            );
        }
    }
}
