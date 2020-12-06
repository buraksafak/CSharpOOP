using System;

//Sabit ve değiştirilmesini istemediğimiz özellikler için static sınıfları, metotları kullanırız.
namespace StaticMembers
{
    class Student
    {
        public string Name { get; set; }

        public int StudentNumber { get; set; }

        //Okul adını tutan static özellik.
        public static string School = "Süleyman Demirel University";

        //Okul adresini tutan static özellik.
        public static string Address = "Center/Isparta";

        public Student(string name, int studentNumber)
        {
            this.Name = name;
            this.StudentNumber = studentNumber;
        }

        //Öğrenci bilgilerini gösteren metot
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Name : {this.Name} ----- Number : {this.StudentNumber}");

        }
        //Okul bilgilerini gösteren metot.
        public static void DisplaySchoolDetails()
        {                                   //static alandan eriştiğimiz için this kullanmadık.
            Console.WriteLine($"My school : {School} \n My school address : {Address}");
        }
    }

    /*Türkçe karakterleri atan yardımcı sınıf.
    (Math. dediğimizde math yardımcı sınıfını kullanırız.
    Bu sınıfı da math sınıfı gibi düşünebiliriz.Aşağıda kullanırken nesne üretmeye gerek kalmaz)*/
    static class HelperMethods
    {
        public static string CharacterEdit(string str)
        {
            return str
                    .Replace("ö","o")
                    .Replace("ü","u")
                    .Replace("ç","c")
                    .Replace("ş","c")
                    .Replace(" ","_")
                    .Replace("ğ","g");                  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Burak", 150);
            var s2 = new Student("Burhan", 151);
            var s3 = new Student("Faruk", 152);


            Student.DisplaySchoolDetails();

            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            s3.DisplayStudentDetails();

            string str = "ölçme ve değerlendirme";
            var result = HelperMethods.CharacterEdit(str);
            Console.WriteLine(result);
        }

    }
}
