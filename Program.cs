using System;
using System.Collections;
using System.Collections.Generic;
using model;

class Employee
{
    public string name;
    public int age;
    public double salary;
    public string dob;
    public int id;

    public static List<my_model> details = new List<my_model>();

    public void create()
    {
        Random rn = new Random();
       // Console.WriteLine("enter id:");
       // id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter name:");
        name = Console.ReadLine();
        Console.WriteLine("enter age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter salary:");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter dob:");
        dob = Console.ReadLine();
        details.Add(new my_model() { Id = rn.Next(0,100) ,Name = name, Age = age, Salary = salary, Dob = dob });
        Console.WriteLine();
        
        
        
        
    }
    public static void Read_all()
    {
        foreach (var item in details)
        {
            Console.Write(item.Id);
            Console.Write('\t');
            Console.Write(item.Name);
            Console.Write('\t');
            Console.Write(item.Age);
            Console.Write('\t');
            Console.Write(item.Salary);
            Console.Write('\t');
            Console.WriteLine(item.Dob);
        }
    }

    public void read()
    {
        int ch;
        Console.WriteLine("1.Read by Id\n2.Read All");
        ch = Convert.ToInt32(Console.ReadLine());
        switch(ch)
        {
            case 1:
                int id;
                Console.WriteLine("enter the Id to read:");
                id = Convert.ToInt32(Console.ReadLine());   
                foreach(my_model detail in details)
                {
                    if(detail.Id == id)
                    {
                        Console.WriteLine("Id\tName\tAge\tSalary\tDob");
                        Console.Write(detail.Id);
                        Console.Write('\t');
                        Console.Write(detail.Name);
                        Console.Write('\t');
                        Console.Write(detail.Age);
                        Console.Write('\t');
                        Console.Write(detail.Salary);
                        Console.Write('\t');
                        Console.WriteLine(detail.Dob);
                        break;
                    }
                    
                }
                break;
            case 2:
                Console.WriteLine("Id\tName\tAge\tSalary\tDob");
                Read_all();
                break;
        }
        

    }

    public  void update()
    {
        int choice;
        bool flag = true;
        while (flag)
        {
            int id;
            Console.WriteLine("enter the Id to update:");
            id = Convert.ToInt32(Console.ReadLine());
            foreach (my_model detail in details)
            {
                if (detail.Id == id)
                {
                    Console.WriteLine("which detail to update (1.name,2.age,3.dob,4.salary) ?");
                    choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case (1):
                            Console.WriteLine("enter new name:");
                            string name;
                            name = Console.ReadLine();
                            detail.Name = name;
                            break;
                        case (2):
                            Console.WriteLine("enter new age:");
                            int age;
                            age = Convert.ToInt32(Console.ReadLine());
                            detail.Age = age;
                            break;
                        case (3):
                            Console.WriteLine("enter new dob:");
                            string dob;
                            dob = Console.ReadLine();
                            detail.Dob = dob;
                            break;
                        case (4):
                            Console.WriteLine("enter new salary:");
                            double salary;
                            salary = Convert.ToDouble(Console.ReadLine());
                            detail.Salary = salary;
                            break;
                    }
                    break;
                }

            }
        
            Console.WriteLine("whether need to modify anything y or n :");
            char cont = Console.ReadLine()[0]; 
            if (cont == 'n')
            {
                flag = false;
                Console.WriteLine("update operation completed");
            }
        }
        
    }
    public void delete()
    {
        int id;
        Console.WriteLine("enter the Id to delete:");
        id = Convert.ToInt32(Console.ReadLine());
        foreach (my_model detail in details)
        {
            if (detail.Id == id)
            {
                details.Remove(detail);
                Console.WriteLine("delete operation completed");
                break;
            }
            else { Console.WriteLine("details not found for this Id"); }
        }

    }
}
class Driver : Employee
{
    public static  int choice;

    public static void Main(String[] args)
    {
        bool Flag = true;
        int exit;   
        Employee emp = new Employee();
        while (Flag) 
        {
            Console.WriteLine("-------->EMPLOYEE MANAGEMENT SYSTEM<---------");
            Console.WriteLine("Select which operation to perform:\n1.CREATE\n2.READ\n3.UPDATE\n4.DELETE\n5.Exit");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    emp.create();
                    Console.WriteLine("CREATED DETAILS ARE:");
                    Console.WriteLine("Id\tName\tAge\tSalary\tDob");
                    Read_all();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    emp.read();
                    break;
                case 3:
                    Console.WriteLine();
                    emp.update();
                    break;
                case 4:
                    Console.WriteLine();
                    emp.delete();
                    break;
                case 5:
                    Flag = false;
                    break;
          

            }
      
        }
        

        
    }

}