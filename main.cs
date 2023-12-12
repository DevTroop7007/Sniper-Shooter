using System;

class Program {
  public static void Main (string[] args) {

    
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine ("▄︻デ══━一💥\t Sniper Shooooooter :|=|=|: Who is LUCKEY!!!\t ▄︻デ══━一💥");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Controls:");
    Console.WriteLine("\t Each player has 500HP. Press ENTER to simulate. ");
    Console.WriteLine("Enter your name:");
    Console.Write("Enter 1st player's name:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string pp1 = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter 2nd player's name:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string pp2 = Console.ReadLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;

    string p1;
    string p2;
    Console.WriteLine("Now TOSSS!!!");
    Console.WriteLine("Enter 1st player's choice :: 1:HEADS or 2:TAILS");
    string toss = Console.ReadLine();

    Random coinflip = new Random();
    int flip = coinflip.Next(1,3);
    if(flip == 1){
      Console.WriteLine("HEADS is the call.");
    }else if(flip == 2){
      Console.WriteLine("TAILS is the call.");
    }


    if(toss == "1" && flip == 1 || toss == "2" && flip == 2 ){
      p1 = pp1;
      p2 = pp2;
      Console.WriteLine(pp1 +" will shoot first\n");
    }else{
      p1 = pp2;
      p2 = pp1;
      Console.WriteLine(pp2 +" will shoot first\n");
      
    }
    
    
    play_again:
    Console.WriteLine("So," + p1 + " and " + p2 + " LET'S BEGIN THE WAR!\n");
    Console.ResetColor();

    //DAMAGE VARIABLES




    
    int h1 = 500;
    int h2 = 500;

    Random NumGen = new Random();
    int D1 = NumGen.Next(1,101);
    int D2 = NumGen.Next(1,101);
    int D3 = NumGen.Next(1,101);
    int D4 = NumGen.Next(1,101);
    int D5 = NumGen.Next(1,101);
    int D6 = NumGen.Next(1,101);
    int D7 = NumGen.Next(1,101);
    int D8 = NumGen.Next(1,101);
    int D9 = NumGen.Next(1,101);
    int D10 = NumGen.Next(1,101);
    int D11 = NumGen.Next(1,101);
    int D12 = NumGen.Next(1,101);
    int D13 = NumGen.Next(1,101);
    int D14 = NumGen.Next(1,101);
    int D15 = NumGen.Next(1,101);
    int D16 = NumGen.Next(1,101);
    int D17 = NumGen.Next(1,101);
    int D18 = NumGen.Next(1,101);
    int D19 = NumGen.Next(1,101);
    int D20 = NumGen.Next(1,101);
    int D21 = NumGen.Next(1,101);
    int D22 = NumGen.Next(1,101);
    int D23 = NumGen.Next(1,101);
    int D24 = NumGen.Next(1,101);
    int D25 = NumGen.Next(1,101);
    int D26 = NumGen.Next(1,101);

    Console.ForegroundColor = ConsoleColor.DarkRed;
    
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D1);
    h2 = h2 - D1;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2 );
    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D2);
    h1 = h1 - D2;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D3);
    h2 = h2 - D3;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D4);
    h1 = h1 - D4;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D5);
    h2 = h2 - D5;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D6);
    h1 = h1 - D6;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D7);
    h2 = h2 - D7;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D8);
    h1 = h1 - D8;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D9);
    h2 = h2 - D9;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D10);
    h1 = h1 - D10;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D11);
    h2 = h2 - D11;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D12);
    h1 = h1 - D12;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D13);
    h2 = h2 - D13;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D14);
    h1 = h1 - D14;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D15);
    h2 = h2 - D15;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D16);
    h1 = h1 - D16;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D17);
    h2 = h2 - D17;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D18);
    h1 = h1 - D18;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D19);
    h2 = h2 - D19;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D20);
    h1 = h1 - D20;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D21);
    h2 = h2 - D21;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);
    
    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D22);
    h1 = h1 - D22;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D23);
    h2 = h2 - D23;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D24);
    h1 = h1 - D24;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(p1 + " sniped ---> "+ p2 +" ::: Damage =" + D25);
    h2 = h2 - D25;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(p2 + " sniped ---> "+ p1 +" ::: Damage =" + D26);
    h1 = h1 - D26;
    Console.WriteLine("Health ::: "+ p1 + "=" + h1 + "   ~~~  " + p2 + "=" + h2);

    if(h1 <= 0){
      Console.WriteLine(p2 + " WON THE GAME!!!");
      goto f;
    }else if(h2 <= 0){
      Console.WriteLine(p1 + " WON THE GAME!!!");
      goto f;
    }else{
      Console.WriteLine("");
    }

    Console.ReadKey();

    if(h1>h2){
      Console.WriteLine(p1 + "WON THE GAME!!! ");
    }else if(h1<h2){
      Console.WriteLine(p2 + " WON THE GAME!!! ");
   }else if(h1 == h2){
			Console.WriteLine(" THE GAME IS A DRAW!!!");
	}else{
      Console.WriteLine("");
  }
    Console.ReadKey();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    f:
    Console.WriteLine("Hope that it was a nice game :)");
    Console.WriteLine("Do you want to play again? (Y/N)");
    
    string pa = Console.ReadLine();
    if(pa == "Y" || pa == "y"){
      Console.WriteLine("Thanks, press ENTER to play again.");
      Console.ReadKey();
      goto play_again;  
    }else{
      Console.WriteLine("Thanks for playing :)");
    }
    Console.ResetColor();

    }
}
