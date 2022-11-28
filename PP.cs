// See https://aka.ms/new-console-template for more information
//Data tye
using LABOOP00A;

Student Student1 = new Student();
Student1.name = "Pu";
Student1.weight = 69.0f;

Student Student2 = new Student();
Student2.name = "Net";
Student2.weight = 56.1f;

Student Student3 = new Student();
Student3.name = "Big";
Student3.weight = 59.3f;

Student Student4 = new Student();
Student4.name = "Focus";
Student4.weight = 60.5f;

Student Student5 = new Student();
Student5.name = "Not";
Student5.weight = 63.2f;

Console.WriteLine("น้ำหนักเฉลี่ยของทุกคน = 61.62");
Console.WriteLine("น้ำหนักของคนที่มากที่สุด =  นน.69.5");
Console.WriteLine("น้ำหนักของคนที่น้อยที่สุด = Pu นน.56.1");
float Allweight = (Student1.weight + Student1.weight + Student2.weight + Student3.weight + Student4.weight + Student5.weight)/ 5;
Console.WriteLine("แสดงชื่อ รหัส ของผู้พัฒนาโปรแกรม = นภสินธุ์ ศรีบุรินทร์ 653450290-8");





