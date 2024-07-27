using Microsoft.EntityFrameworkCore;
using Task1._1.entities;

namespace Task1._1;

class Program
{
     
    static void Main(string[] args)
    { 
           AdventureWorks2019Context dbContext = new AdventureWorks2019Context();

        
       var emps= dbContext.Employees.Include(b=>b.BusinessEntity).Include(c=>c.EmployeeDepartmentHistories)
  .Select(b=>new{employeeid=b.BusinessEntityId,
  name="("+b.BusinessEntity.FirstName +" "+b.BusinessEntity.MiddleName +" "+b.BusinessEntity.LastName +")",gender=b.Gender,hiredate=b.HireDate,
  dept=b.EmployeeDepartmentHistories.Select(b=>new {
    empdeptcurrent=b.Department.Name
  }).FirstOrDefault()}).ToList();

Console.WriteLine("=================================================");
foreach(var item in emps){Console.WriteLine(item);}
  var alldeps=dbContext.Departments.Include(c=>c.EmployeeDepartmentHistories)
  .Select( b=> new{deptid=b.DepartmentId,deptname=b.Name,total=b.EmployeeDepartmentHistories.GroupBy(b=>b.BusinessEntityId).Select(b=>new{c=b.Key})}).ToList();

Console.WriteLine("=================================================");
foreach(var item in alldeps){Console.WriteLine(item);}

var allshift=dbContext.EmployeeDepartmentHistories.Include(e=>e.Shift).Select(b=>new{shiftid=b.ShiftId,shiftname=b.Shift.Name,stime=b.Shift.StartTime
,etime=b.Shift.EndTime,emp=b.BusinessEntity.EmployeeDepartmentHistories.Select(b=>new{empdeptcurrent=b.Department.Name}).FirstOrDefault(),emname=
b.BusinessEntity.BusinessEntity.BusinessEntity.Person.FirstName
}).ToList();
foreach(var item in allshift){
    //Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.WriteLine(item);
    }


    }
}
