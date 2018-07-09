/*
    Function: override
*/
using System;
namespace Class1
{
    class Employee
    {
        //父类虚方法
        public virtual void CalculatePay()
        {
            Console.WriteLine("Employee");
        }

        public void Name() { }
    }

    //子类继承重写CalculatePay()方法
    class SalariedEmploy : Employee
    {
        public override void CalculatePay()
        {
            Console.WriteLine("Salary");
        }
        public new void Name() { }
    }

    class S3 : SalariedEmploy
    {
        public override void CalculatePay()
        {
            //base.CalculatePay();
        }
    } 
} 