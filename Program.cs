using System.IO.Compression;

namespace metotoverloadiing;

class Program
{
    static void Main(string[] args)
    {
        //out parameter
        string sayi="999";
       
        
        bool result=int.TryParse(sayi,out int outSayi);
        if(result){
            Console.WriteLine("Convert has been  succesful");
            Console.WriteLine(outSayi);
        }else{
             Console.WriteLine("Convert have been unsuccessful ");
        }
        Metots instance=new Metots();
        instance.sumMetot(2,3,out int sumResoult);
        Console.WriteLine(sumResoult);

        instance.printScreen(sayi);
        instance.printScreen(555,555);

        //metot overloading

    }
    class Metots{
        public void sumMetot(int a1, int b1, out int sumValues){
            sumValues=a1+b1;
        }
        public void printScreen(string s1){
            Console.WriteLine(s1);

        }
        public void printScreen(int s1){
            Console.WriteLine(s1);

        }
        public void printScreen(int s1, int s2){
            Console.WriteLine(s1+s2);

        }


    }
}
