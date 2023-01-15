class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for(int i =0; i < subjects.Length; i++)
        {
            System.Console.WriteLine(subjects[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        //Create object of student class
        Student s = new Student();

        //Access DisplaySubjects method
        s.DisplaySubjects("Science", "Mathematics", "Geography", "History", "English");
    }
}
