﻿class Employees
{
    int _empId = 1;
    string _empName = "James Anderson";
    int _age = 25;
    public void Display()
    {
        Console.WriteLine("Emplyee ID: " + _empId);
        Console.WriteLine("Emplyee ID: " + _empName);
    }
}

class Department : Employees
{
    int _deptId = 501;
    string _deptName = "Sales";
    new void Display()
    {
        base.Display();
        Console.WriteLine("Department ID: " + _deptId);
        Console.WriteLine("Department Name: " + _deptName);
    }

    static void Main(string[] args)
    {
        Department objDepartment = new Department();
        objDepartment.Display();
    }
}
