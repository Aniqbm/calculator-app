using system;

namespace CalculatorConsoleApp{
class Calculator {
	static void main (string[]args)
	{
		Console.Title = "Aplikasi calculator"
		int a = 10;
		int b = 6;
	
		
		 Console.WriteLine("Hasil penambahan "+ a +" + "+ b +" = "+ panambahan(a,b));
         Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a,b, pengurangan (a, b));
         Console.WriteLine("Hasil perkalian {0} * {1} = {2}",a,b, perkalian(a, b));
         Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

         Console.WriteLine("\nTekan sembarang key untuk keluar");
         Console.ReadKey();
	}
	static int penambahan(int a, int b){
	return a + b;}
}
	static int penambahan(int a, int b){
	return a - b;}
}
}