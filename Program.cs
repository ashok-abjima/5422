using System;

class Test
{
    int i =0;
    static int j = 0;

    public void SetData()
    {
        i++;
        j++;
    }
    public void GetData()
    {
        Console.WriteLine("{0} {1}",i,j);
    }

}
class Program
{
    static void Main()
    {
        Test ob = new Test();
       


        Test ob1 = new Test();
        ob1.SetData();
        ob.GetData();
        ob1.GetData();

        Console.ReadKey();
    }
}