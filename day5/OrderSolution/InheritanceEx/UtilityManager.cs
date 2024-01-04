namespace Mathematics;
using System.Diagnostics;

public static class UtilityManager{
    public static void Calculate(float radius){
        float area = (3.14f) * radius * radius;
        Console.WriteLine("The area of circle is "+area);
    }


    public static void Swap(ref int a, ref int b){
        Console.WriteLine("Before swapping " + a + ", " + b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After swapping " + a + ", " + b);
    }

    public static void ShowNames(params object[] names){
        foreach(object name in names){
            Console.WriteLine(name); 
        }
    }

    public static int Division(this MathEngine e,int num1, int num2){ 
        return num1 / num2;
    }

    public static int Multiplication(this MathEngine e, int num1, int num2){
        return num1 * num2;
    }
}