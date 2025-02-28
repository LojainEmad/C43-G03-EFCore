using EntityFrameWork_Assignment.Contexts;
using EntityFrameWork_Assignment.Models;

namespace EntityFrameWork_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIEntityDBContext DBContext = new ITIEntityDBContext(); 

            #region Crud Operations on Student
            //using (var context = new ITIEntityDBContext())
            //{
            //    var student1 = new Student
            //    {
            //        FName = "Lojain",
            //        LName = "Emad",
            //        Age = 21,
            //        Address = "Cairo"
            //    };
            //    var student2 = new Student
            //    {
            //        FName = "Ali",
            //        LName = "Ahmed",
            //        Age = 23,
            //        Address = "Alex"
            //    };
            //    //1.add
            //    context.Students.Add(student1);
            //    context.Students.Add(student2);
            //    context.SaveChanges();
            //    Console.WriteLine("Addition done");
            //    Console.WriteLine("==================");
            //    //2.retrieve
            //    var students = context.Students.ToList();
            //    Console.WriteLine("\nstudents are :");
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine($"ID: {student.StudentId}, Name: {student.FName} {student.LName}, Age: {student.Age}, Address: {student.Address}");
            //    }

            //    // 3.update
            //    var updatedStudent = context.Students.FirstOrDefault(s => s.FName == "Logy");
            //    if (updatedStudent != null)
            //    {
            //        updatedStudent.Age = 24;
            //        updatedStudent.Address = "Giza";
            //        context.SaveChanges();
            //        Console.WriteLine("\nstudent details updated ");
            //    }

            //    // 4.remove
            //    var RemovedStudent = context.Students.FirstOrDefault(s => s.FName == "Logy");
            //    if (RemovedStudent != null)
            //    {
            //        context.Students.Remove(RemovedStudent);
            //        context.SaveChanges();
            //        Console.WriteLine("\nstudent");
            //    }
            //}
            #endregion

            #region Crud OPerations on Department

            //using (var context = new ITIEntityDBContext()) 
            //{
            //    // 1. Add
            //    var department = new Department
            //    {
            //        Name = "CS",
            //    };
            //    context.Departments.Add(department);
            //    context.SaveChanges();
            //    Console.WriteLine("department added");

            //    // 2. Retrieve 
            //    var retrievedDept = context.Departments
            //        .FirstOrDefault(d => d.Name == "CS");

            //    if (retrievedDept != null)
            //    {
            //        Console.WriteLine($"\n department: Id: {retrievedDept.Id}, name: {retrievedDept.Name}, created on sql: {retrievedDept.CreationDate}");
            //    }

            //    // 3. update
            //    if (retrievedDept != null)
            //    {
            //        retrievedDept.Name = "SC";
            //        context.SaveChanges();
            //        Console.WriteLine("\ndepartment name updated");
            //    }

            //    // 4. remove
            //    if (retrievedDept != null)
            //    {
            //        context.Departments.Remove(retrievedDept);
            //        context.SaveChanges();
            //        Console.WriteLine("\ndepartment removed");
            //    }
            //}

            #endregion

            #region Crud Operations on Instructor

            //using (var context = new ITIEntityDBContext())
            //{
            //    //1 add
            //    var newInstructor = new Instructor
            //    {
            //        Name = "Ali",
            //        Bonus = 100.00m,
            //        Salary = 5000.00m,
            //        HourRate = 150.00m,
            //        Address = "Cairo",
            //    };
            //    context.Instructors.Add(newInstructor);
            //    context.SaveChanges();
            //    Console.WriteLine($"Instructor {newInstructor.Name} with ID {newInstructor.InstructorId}");

            //    //2 retrive
            //    var instructor = context.Instructors.FirstOrDefault(i => i.Name == "Ali");
            //    if (instructor != null)
            //    {
            //        Console.WriteLine($"instructor here : {instructor.Name}, salary: {instructor.Salary}");
            //    }

            //    //3 update
            //    if (instructor != null)
            //    {
            //        instructor.Salary += 500;
            //        context.SaveChanges();
            //        Console.WriteLine($"instructor {instructor.Name}his new salary: {instructor.Salary}");
            //    }

            //    //4 delete
            //    if (instructor != null)
            //    {
            //        context.Instructors.Remove(instructor);
            //        context.SaveChanges();
            //        Console.WriteLine($"instructor {instructor.Name} deleted successfully.");
            //    }
            //}

            #endregion

            #region Crud Operations on Topic
            //using (var context = new ITIEntityDBContext())
            //{
            //    //1 add
            //    var newTopic = new Topic
            //    {
            //        Name = "OOP"
            //    };

            //    context.Topics.Add(newTopic);
            //    context.SaveChanges();
            //    Console.WriteLine($"topic {newTopic.Name} with ID {newTopic.TopicId}");

            //    //2 retrive
            //    var topic = context.Topics.FirstOrDefault(t => t.Name == "OOP");
            //    if (topic != null)
            //    {
            //        Console.WriteLine($"topic is : {topic.Name}, ID: {topic.TopicId}");
            //    }

            //    //3 update
            //    if (topic != null)
            //    {
            //        topic.Name = "algorithm";
            //        context.SaveChanges();
            //        Console.WriteLine($"topic updated to {topic.Name}");
            //    }

            //  //  4 delete
            //    if (topic != null)
            //    {
            //        context.Topics.Remove(topic);
            //        context.SaveChanges();
            //        Console.WriteLine($"topic {topic.Name} deleted ");
            //    }
            //}
            #endregion

            #region Crud operations on Course_Inst
            //using (var context = new ITIEntityDBContext()) // Replace with your actual DbContext
            //{
            //    //1 add
            //    var newCourseInst = new Course_Inst
            //    {

            //        Evaluate = 'B'
            //    };
            //    context.Course_Insts.Add(newCourseInst);
            //    context.SaveChanges();
            //    Console.WriteLine($"course_Inst added with evaluation {newCourseInst.Evaluate}");

            //    //2 retrieve
            //    var courseInst = context.Course_Insts
            //                            .FirstOrDefault();

            //    if (courseInst != null)
            //    {
            //        Console.WriteLine($"Course_Inst is : courseId={courseInst.CourseId}, InstructorId={courseInst.InstructorId}, evaluate={courseInst.Evaluate}");
            //    }

            //    //3 update
            //    if (courseInst != null)
            //    {
            //        courseInst.Evaluate = 'A'; // Update evaluation
            //        context.SaveChanges();
            //        Console.WriteLine($"Course_Inst evaluation updated to {courseInst.Evaluate}");
            //    }

            //    //4 delete
            //    if (courseInst != null)
            //    {
            //        context.Course_Insts.Remove(courseInst);
            //        context.SaveChanges();
            //        Console.WriteLine($"course_Inst with Evaluation {courseInst.Evaluate} deleted");
            //    }
            //}
            #endregion

            #region Crud operations on Stud_Course
            //using (var context = new ITIEntityDBContext())
            //{
            //    //1 add
            //    var newStudCourse = new Stud_Course
            //    {

            //        Grade = 'A'
            //    };

            //    context.Stud_Course.Add(newStudCourse);
            //    context.SaveChanges();
            //    Console.WriteLine("Stud_Course added ");

            //    //2 retrieve
            //    var studCourse = context.Stud_Course.FirstOrDefault();
            //    if (studCourse != null)
            //    {
            //        Console.WriteLine($"Stud_Course : Grade = {studCourse.Grade}");
            //    }

            //    //3 update
            //    if (studCourse != null)
            //    {
            //        studCourse.Grade = 'B';
            //        context.SaveChanges();
            //        Console.WriteLine("Stud_Course updated ");
            //    }

            //    // DELETE
            //    if (studCourse != null)
            //    {
            //        context.Stud_Course.Remove(studCourse);
            //        context.SaveChanges();
            //        Console.WriteLine("Stud_Course deleted ");
            //    }
            //}
            #endregion

            #region Crud operations on course

            //using (var context = new ITIEntityDBContext())
            //{
            //    //1 add
            //    var newCourse = new Course
            //    {
            //        Name = "C# ",
            //        Duration = TimeSpan.FromHours(10),
            //        Description = "C# is perfect",
            //    };

            //    context.Courses.Add(newCourse);
            //    context.SaveChanges();
            //    Console.WriteLine("Course added ");

            //    // 2 retrieve
            //    var course = context.Courses.FirstOrDefault();
            //    if (course != null)
            //    {
            //        Console.WriteLine($"course found: {course.Name}, duration: {course.Duration}");
            //    }

            //    //3 update
            //    if (course != null)
            //    {
            //        course.Description = "updated: C# is interesting ";
            //        context.SaveChanges();
            //        Console.WriteLine("Course updated ");
            //    }

            //    //4 delete
            //    if (course != null)
            //    {
            //        context.Courses.Remove(course);
            //        context.SaveChanges();
            //        Console.WriteLine("Course deleted ");
            //    }
            //}
            #endregion
        }
    }

 }
    

