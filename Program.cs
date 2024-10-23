using System;
using System.Runtime.ExceptionServices;

class Program {
 static void Main() {
      
      //Chci, aby se program opakoval po stisku klávesy "a"
     string again = "a";
     // "==" porovnává, "=" přiřazení, čtení z prava do leva
     while(again == "a"){
         Console.Clear();
         Console.WriteLine("===============================");
         Console.WriteLine("========== Výpis řady =========");
         Console.WriteLine("===============================");
         Console.WriteLine("========= Šanda Dominik =======");
         Console.WriteLine("===============================\n");
         Console.WriteLine();

         //Vstup od uživatele - Špatná varianta
        //Console.Write("Zadejte první číslo řady: ");
        //int first = int.Parse(Console.ReadLine());

         //Vstup od uživatele - správně
        Console.Write("Zadejte první číslo řady (celé číslo): ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first)){
            Console.Write("Nezadali jste celé číslo.\n Zadejte znovu první číslo řady (celé číslo):");
       }
                Console.Write("Zadejte poslední číslo řady (celé číslo): ");
        int last;
        while(!int.TryParse(Console.ReadLine(), out last)){
            Console.Write("Nezadali jste celé číslo.\n Zadejte znovu poslední číslo řady (celé číslo):");
       }
                Console.Write("Zadejte diferenci (celé číslo): ");
        int step;
        while(!int.TryParse(Console.ReadLine(), out step)){
            Console.Write("Nezadali jste celé číslo.\n Zadejte znovu diferenci (celé číslo):");
       }

       // vypis uživatelských hodnot
       Console.WriteLine();
       Console.WriteLine("============================");
       Console.WriteLine("První číslo řady: {0}", first);
       Console.WriteLine("Poslední číslo řady: {0} ", last);
       Console.WriteLine("Diference: {0}", step);
       Console.WriteLine("============================");
       
         //Logika pro výpis řady - TO DO

         int current = first;
         while(current <= last){
            Console.WriteLine(current);
            current = current + step;
         }

         // Opakování programu
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

          
     }


 }

}