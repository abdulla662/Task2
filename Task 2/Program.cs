namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> modifiedlist = new List<int>() { 33,1, 2, 3, 4, 5, 22,6, 7,8 };






            char selection = '\0';
            do
            {
                Console.WriteLine("P-Print numbers");
                Console.WriteLine("A-Add numbers");
                Console.WriteLine("D-Display Mean of Numbers");
                Console.WriteLine("S-Display smallest numbers");
                Console.WriteLine("L-Display largest numbers");
                Console.WriteLine("F-Find index of number");
                Console.WriteLine("C-Clear all list ");
                Console.WriteLine("U-order list in ascending");
                Console.WriteLine("X-order list in dscending");
                Console.WriteLine("Q-Quit");
                Console.Write("Enter your choice: ");
              
                selection = char.ToUpper(char.Parse(Console.ReadLine()));
             

                switch (selection)
                {
                    case 'P':
                        if (modifiedlist.Count == 0) {
                            Console.WriteLine("your list is empty nothing to show try add using A");
                            continue;
                        }
                       
                            Console.Write("[");
                        for (int i = 0; i < modifiedlist.Count; i++)
                        {  
                            Console.Write($"{modifiedlist[i]},");
                        
                        }
                        Console.WriteLine("]");

                        Console.WriteLine();
                        break;
                    case 'A':
                       Console.WriteLine("Please Add a number ");
                        int newNumber = int.Parse(Console.ReadLine());
                        if (modifiedlist.Contains(newNumber)) {                      ///https://www.programiz.com/csharp-programming/library/string/contains //
                            Console.WriteLine("Number already exists.");
                            continue;

                        }
                        else {  
                            
                            modifiedlist.Add(newNumber);
                        Console.WriteLine("number has been added succefully !");
                            continue;

                        }

                        break;
                        case 'D':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                            continue;
                        }
                        int sum = 0;
                        int count= modifiedlist.Count;
                        for (int i = 0; i <count; i++) { 
                        sum += modifiedlist[i];
                        }
                        Console.WriteLine($"the mean is approximately =  {sum/count}");
                        break;

                    case 'S':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                            continue;

                        }
                        int min = modifiedlist[0];
                        for (int i = 0; i < modifiedlist.Count; i++) {
                            if (modifiedlist[i] < min)  
                            {
                                min = modifiedlist[i];
                            }
                        }
                        Console.WriteLine(min);
                        break;
                    case 'L':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                            continue;

                        }
                        int max = modifiedlist[0];
                        for (int i = 0; i < modifiedlist.Count; i++)
                        {
                            if (modifiedlist[i] > max)
                            {
                                max = modifiedlist[i];
                            }
                        }
                        Console.WriteLine(max);
                        break;
                    case 'F':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                            continue;

                        }
                        Console.WriteLine("please enter number you want to search for ");
                        int isavilabe = 0;
                        bool numberfound = false;
                        int SearchedNumber=int.Parse(Console.ReadLine());
                        if (modifiedlist.Contains(SearchedNumber)) {
                            for (int i = 0; i < modifiedlist.Count; i++) {
                                if (modifiedlist[i] == SearchedNumber)
                                {
                                    isavilabe = i;
                                    numberfound = true;
                                }
                               

                            }
                            }
                        if (numberfound == true) {
                            Console.WriteLine($"your number is at index {isavilabe}");
                            continue;


                        }
                        else {
                            Console.WriteLine($"your number is not avilable try  adding it using A 😊");
                            continue;


                        }
                        break;
                    case 'C':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                            continue;

                        }
                        modifiedlist.Clear();
                        Console.WriteLine("list has been cleared succefully");
                        break;
                        case 'U':

                        if (modifiedlist.Count == 0) {
                            Console.WriteLine("your list is already empty 😊");
                            continue;

                        }
                        int swap;
                        for (int i = 0; i < modifiedlist.Count; i++) {
                            for (int k = 0; k < modifiedlist.Count - 1; k++) {
                                if (modifiedlist[k] > modifiedlist[k + 1]) {
                                    swap=modifiedlist[k+1];
                                    modifiedlist[k+1]=modifiedlist[k];
                                    modifiedlist[k]=swap;

                                }

                            }
                           
                        }

                        Console.WriteLine("Your array sorted ascendingly:");
                        for (int i = 0; i < modifiedlist.Count; i++)
                        {
                            Console.WriteLine($"Element at index {i + 1}: {modifiedlist[i]}");
                        }


                        break;
                    case 'X':
                        if (modifiedlist.Count == 0)
                        {
                            Console.WriteLine("your list is empty nothing to show");
                        }
                        int temp;
                        for (int i = 0; i < modifiedlist.Count; i++) {
                            for (int k = 0; k < modifiedlist.Count - 1; k++) {
                                if (modifiedlist[k] < modifiedlist[k + 1]) { 
                                temp = modifiedlist[k+1];
                                    modifiedlist[k+1]=modifiedlist[k];
                                    modifiedlist[k] =temp;
                                }
                            }
                        }
                        Console.WriteLine("Your array sorted descendingly:");
                        for (int i = 0; i < modifiedlist.Count; i++)
                        {
                            Console.WriteLine($"Element at index {i + 1}: {modifiedlist[i]}");
                        }
                        break;
                            default :
                        Console.WriteLine("please enter correct input");
                        break;
                }
            


            } while (selection != 'Q') ;
                Console.WriteLine("Good Bye !");
            }
    }
}


