using System;
class program{
    public static void Main() {
	int a=10, b=20;
	BytPlats(ref a,ref b);
	//Här ska a ha värdet 20 och b värdet 10. 
	Console.WriteLine( a+" "+b);
}
	
	public static void BytPlats(ref int a, ref int b) {
		int s=a; // så här funkar funktionen om varibel value ändras
      a=b;
      b=s;

      
}

}