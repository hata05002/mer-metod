using System;
class program{
      public static void Main()
{
	Console.WriteLine("10 upphöjt till 7: "+Power(10,7));
	Console.WriteLine("2 upphöjt till 10: "+Power(2,10));
}

static double Power(double a, int b){
double tal=1;
for(int i=0; i<b;i++) {
    tal= tal*a;
}
return tal;
}

}