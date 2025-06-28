

using System.Text;

internal class SuppAssgn
{
    public bool IsPrime(int n) //P1 - Check for Prime number
    {
        if (n == 0 || n == 1) return false;
        for (int i = 2; i <= n / 2; i++) /* We will check the factors till half of the number because once it 
                                     * crossed half then the quotient will be in between 1 and 1.9 only till
                                     * the number itself, so no need to check after half of the number.*/
        {
            if (n % i == 0) return false;
        }
        return true;
    }


    public void Swap()  // P2 - Swap without third variable and without addition & subtraction
    {
        Console.Write("Enter Value for A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter Value for B: ");
        int b = int.Parse(Console.ReadLine());

        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine("Values after Swapping: ");
        Console.WriteLine("Value for A: " + a);
        Console.WriteLine("Value for B: " + b);

    }

    public int Reverse(int n) // P3 - Reverse of a given number
    {
        int d = 0, rvs = 0;
        while (n > 0) //Till number becomes zero after dividing
        {
            d = n % 10; // getting the remainder means the last digit
            rvs = rvs * 10 + d; // forming the new reverse number 
            n = n / 10;// removing the last digit as we have inserted it in the reverse number
        }
        return rvs;
    }

    public int binary(int n)  // P4 - Binary using recursion
    {
        int bin = 0;
        if (n == 0) return 0;  // if the number is 0 then binary will also be 0 and same for 1
        else if (n == 1) return 1;
        else
        {
            int r = 0;
            r = n % 2; // storing the remainder getting after dividing by 2
            bin = binary(n / 2) * 10 + r;  // now calling the binary again but without the last digit because that we have
                                           // already considered and it will be placed at the right position when it 
                                           // will get the value in return.
                                           // And it will happen recursively till the number becomes zero and binary will be completed at that time.
        }
        return bin;

    }

    public int binarri(int n)  //P4 - Binary Search using array and iteration
    {
        int bin = 0, i = 0;
        int[] arr = new int[16];
        while (n > 0)
        {
            arr[i++] = n % 2; // storing the remainders which will be the digits of binary code in an array
            n = n / 2;
            if (n == 1) arr[i] = 1;   // storing 1 in the last because it will be quotient
        }
        for (int j = i; j >= 0; j--)
        {
            bin = bin * 10 + arr[j]; // converting the array into the number because array has stored the binary code in reverse. 
        }
        return bin;

    }


    public bool palindrome(int n) //P5 - Check for palindrome
    {
        return n == Reverse(n);
    }

    public void fibo(int ub) //P6 - Print Fibonacci series upto upper bound
    {
        int[] a = new int[ub];
        a[0] = 0; a[1] = 1;
        for (int i = 2; i < ub; i++)
        {
            a[i] = a[i - 1] + a[i - 2];
        }
        foreach (int i in a)
            Console.Write(i + " ");
    }

    public int factItr(int n) //P7  - Factorial using interation
    {
        int fact = 1;
        for (int i = n; i > 0; i--)
            fact *= i;
        return fact;
    }

    public int factRec(int n) //P7  - Factorial using recursion
    {
        if (n == 0 || n == 1) return 1;

        int fact = n * factRec(n - 1);
        return fact;
    }

    public bool armstrong(int n) //P8 - Check for Armstrong number
    {
        int num = n, rem = 0, nod = 0;
        while (n > 0)
        {
            rem = n % 10;
            nod++;
            n = n / 10;

        }
        int sum = 0;
        int org = num;
        while (num > 0)
        {
            rem = num % 10;
            sum += (int)Math.Pow(rem, nod);
            num /= 10;

        }
        return sum == org;

    }

    public int sod(int n) //P9 - Sum of digits of given number
    {
        int sum = 0;
        int rem = 0;
        while (n > 0)
        {
            rem = n % 10;
            sum += rem;
            n /= 10;
        }
        return sum;
    }

    public int rec_ssod(int n) //P10  - Sum of digits until single digit using recursion
    {
        if (n < 9) return n;
        int num = sod(n);
        if (num < 9) return num;
        else return rec_ssod(num);

    }

    public int it_ssod(int n) //P10  -Sum of digits until single digit using iteration
    {
        while (n >9)
        {
            n = sod(n);

        }
        return n;
    }

    public String NumToWrd() //P11- To print given number in words
    {
        Console.Write("Enter the number [<=9999999999]  : ");
        ulong n = ulong.Parse(Console.ReadLine());
        if (n == 0) return "Zero";  // returning zero if number is 0
        String[] unit = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ", "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
        String[] frst = { "", "", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
        String[] scnd = { "Hundred ","Crore " , "Lac ","Thousand "};
        String word = "";  // word will store the result 
        int cnt = 0,i=0;  // cnt is counter for the place of digit and i is iterator for while loop
        int[] wrd=new int[11]; // wrd will store the digits of the entered number
        int lnz = 0;  // last non zero digit in the number for concatenating 'and' in the result at right place
        while (n > 0)
        {
            if(cnt==0|| cnt >= 2)    // for all values except which are at hundredth place decided by counter
            {
                if (n % 100 <= 19)   // digit <= 19 will be stored at one index
                {
                    wrd[i] = (int)(n % 100);
                    if(wrd[i]!=0 && lnz==0) lnz = i+1; // storing the index for last non zero if it is
                    i++;
                    n /= 100;
                    wrd[i++] = 0;
                    cnt++;
                }
                else if (n % 100 > 19) // digit >19 will be stored at two indices like 2 and 3 for 23.
                {
                    wrd[i++] = (int)(n % 10);
                    n /= 10;
                    wrd[i] = (int)(n % 10);
                    if (wrd[i] != 0 && lnz == 0) lnz = i; // storing the index for last non zero if it is
                    i++;
                    n /= 10;
                    cnt++;
                }
            }
            if (cnt == 1)  // for digits only for hundreth place decided by counter
            {
                wrd[i] = (int)(n % 10);
                if (wrd[i] != 0 && lnz==0) lnz = i;
                i++;
                n /= 10;
                cnt++;
            }
        }
        Array.Reverse(wrd); // now wrd contains the digits in reverse order so reversing again to get correct order.

        int s = wrd.Length;
        lnz = s - lnz - 1; // correct index of last non zero digit after reversing
        bool oonz = true; // Only One Non Zero (oonz) for skipping 'and' string in the result
        for(int k =0 ; k < lnz; k++)
        {
            if (wrd[k] != 0) { oonz = false; break; }  // checking whether there is only one non zero or not

        }
            word += (wrd[s-10] == 0 ? "" : $"{unit[wrd[s-10]] + scnd[0]}"); // entering the digits into words after 99 crore.
        if (wrd[s - 10] != 0 && wrd[s - 9] == 0 && wrd[s - 8] == 0) word += "Crore ";// adding 'Crore' for the exception
        for(int j = s-9; j < s-2; j++) // 
        { if (j < s-3 ) // converting till last 4th place
            {if (j % 2 != s%2) word += frst[wrd[j]];
                else { word += unit[wrd[j]];
                    if (wrd[j] !=0 || wrd[j-1] !=0) word += scnd[j / 2];
                }
                }
            if (j == s - 3 ) { // conversion for hundered [3rd place]
                if (j == 0) continue;
                else word += ((wrd[j]==0)?"":unit[wrd[j]] + scnd[0]);
            }
            if (j == lnz - 1 && !oonz) word += "and "; // concatenating 'and' before lnz and if oonz is zero.
        }
        word += frst[wrd[s - 2]] + unit[wrd[s-1]]; // conversion after hundred
        return word;
    }


    public bool IsLeapYear(int n) //P12 - Check for leap year
    {
        if (n % 100 == 0) return n % 400 == 0;
        else return n % 4 == 0;      
    }

    public int MaxInArr(int[] a) //P13 - Give Max Number in Array
    { int max = 0;
        foreach(int j in a)
        {
            if (j > max) max = j;
        }
        return max;
    }

    public String RvrString(String str) //P14 - Reverse the string
    {
        String rvs = "";
        foreach(char ch in str)
        {
            rvs = ch + rvs;

        }
        return rvs;

    }

    public int LenString(String str) //P16 - Find the length of given string
    {
        int cnt = 0;
        foreach(char ch in str)
        {
            cnt++;
        }
        return cnt;
    }
    public int ChrCount(String str) //P17 - Find the number of characters in given string e.g. "Hello    World" -> 10 characters
    {
        int cnt = 0;
        foreach (char ch in str)
        {
            if(ch!=' ') cnt++;
        }
        return cnt;
    }

    public int WrdCnt(String str) //P15 - Find the number of Words in a string e.g. :Hello   World" -> 2 words
    {
        int cnt = 0;
        int iwrd=0,fwrd=0;
        int length = str.Length;
        for (int i = 0; i<length; i++)
        {
            if (str[i] != ' ') { iwrd = i; break; } // gettig the starting index of the first word in the string excluding spaces
        }
        for (int i = length-1;i>=0; i--)
        {
            if (str[i] != ' ') { fwrd = i; break; } // similarly getting last index of last word
        }
        for (int i = iwrd; i<=fwrd; i++)
        {
            if (str[i] == ' ' && str[i-1]!=' ') cnt++; // now counting by ingnoring the intial and  end spaces through iwrd and fwrd and considering the intermediate space only once using the condition.
        }
        return cnt+1;
    }

    public String WrdRvrs(String str) // P18 - Print words in Reverse order e.g. "Hello    world" -> world Hello
    {
        String wrd = "", rvs=""; // wrd to store the single word and rvs will store the whole reversed word string
        for(int i = 0; i<str.Length; i++)
        {
            if (str[i] != ' ') wrd += str[i]; // taken out the word from the string
            else if (str[i] == ' ' && i != 0 && str[i - 1] != ' ') 
                    { rvs = str[i] + wrd + rvs;  // added the above word but before the rvs to reverse the order if not the last word
                wrd = ""; // re-initialized the wrd again with empty string to store new word
                        }
            if (i+1==str.Length) rvs = wrd + rvs; // addition the last word

        }
        return rvs;
    }


    public StringBuilder tolwr(StringBuilder sb) //P19 - Replicate Tolower()
    {
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i]!=' ' && sb[i]>=65 && sb[i]<=90) sb[i] = (char)(32 + sb[i]);
        }

        return sb;
    }

    public StringBuilder toupr(StringBuilder sb) //P20 - Replicate ToUpper()
    {
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] != ' ' && sb[i] >= 97 && sb[i] <= (97+26-1)) sb[i] = (char)( sb[i]-32);
        }

        return sb;
    }

    public StringBuilder topscl(StringBuilder sb) {  // P21 - Create ToPascal()
    
        for(int i = 0; i < sb.Length; i++)
        {
            
            if ((i == 0 && sb[i] != ' ') ||  // if character is first and non-space then convert it to upper    
                (sb[i] != ' ' && i != 0 && sb[i-1] == ' ' && sb[i] >= 97 && sb[i] <= 122)) sb[i] = (char)(sb[i] - 32); // if character is first but after space and is lower then convert it to upper
            if (sb[i]!=' ' && sb[i-1]!=' ' && i!=0 && sb[i] >= 65 && sb[i] <= 90) sb[i] = (char)(sb[i] + 32); //if character is not first and is upper convert it to lower
          
            
        }

        return sb;
    }

    public void unqChar1(StringBuilder sb) {  //P22 - Give unique characters for each word  like "Hello   World" -> E H L O /n D L O R W
                                              //[but for special charactors it just indentifies that there are special characters, doesn't show which special characters are there becasuse that wasn't mentioned in the question, I just added myself].
       
        int c;
        bool[] carr = new bool[27]; // carr will store true for the index who corresponding english alphabet is present in string and at 26th index it will store true if any special character will be present.
      
        int k = 0,cnt=1;
        while(k<sb.Length)
        {
            if (sb[k]!=' ')
            {
                for (int i = k; i<sb.Length?(sb[i] != ' '):false; i++)   // Will run for single word in the string
                {
                    if (((int)sb[i] >= 65 && (int)sb[i] <= 90) || ((int)sb[i] >= 97 && (int)sb[i] <= 122))  // if not any special character or only capital/small letters
                    {
                        c = (int)sb[i];
                        c = c >= 97 ? c -= 97 : c -= 65;  // calculating the index for storing in carr using ascii values
                        carr[c] = true;  // stored true at the index corresponding to the alphabet
                    } 
                    else carr[26] = true;  // otherwise true is stored for 26th index for special character
                        k = i;
                }
                k++;
                Console.Write("The Number of unique Characters in Word " + cnt + " : "); // Printed the Word Number
                cnt++;
                for (int j = 0; j < 27; j++)
                {
                    if (carr[j] && j != 26) // checking which aplhabet's index is set as true 
                    {
                        Console.Write((char)(j + 65) + " ");   // and printing them
                        carr[j] = false;  // re-initializing with false for the use of next word in the string
                    }
                    if (carr[j] && j == 26) { // if speical character is also present 
                        Console.Write("Special Character"); // then informing that special characters are also present
                        carr[26] = false;
                    }

                }
                        Console.WriteLine();
            }
            else k++;
        }
  }



    public void unqChar2(String sb) { //P22 - Unique characters in the whole string with special characters but case sensitive
        int cnt1 = 0, cnt2 = 0; // two counts for nested foreach traversal
        bool exist = false; // variable for know whether another same character exists or not
        Console.Write("Unique Characters: ");
        foreach(char ch1 in sb)
        {
            cnt1++;
            if (ch1 == ' ') continue;
            foreach(char ch2 in sb)
            {
                cnt2++;
                if (cnt1 != cnt2 && ch1 == ch2) exist = true; // if not the same character and duplicate then exist is true

            }
            if (!exist) Console.Write(ch1 + " ");  // if duplicate does not exist print
            cnt2 = 0; exist = false;  // re-initializing for next iteration
        }
        Console.WriteLine();
    }

    public void dupChar1(StringBuilder sb)  //P23 - Gives duplicate character in each word and for special charactors it just indentifies that there are duplicate special characters, doesn't show which special characters are there.
    {

        int c;
        int[] carr = new int[27]; // carr will store integer  for the index who corresponding english alphabet is present in string and at 26th index it will store for special character.

        int k = 0, cnt = 1;
        while (k < sb.Length)
        {
            if (sb[k] != ' ')
            {
                for (int i = k; i < sb.Length ? (sb[i] != ' ') : false; i++)   // Will run for single word in the string
                {
                    if (((int)sb[i] >= 65 && (int)sb[i] <= 90) || ((int)sb[i] >= 97 && (int)sb[i] <= 122))  // if not any special character or only capital/small letters
                    {
                        c = (int)sb[i];
                        c = c >= 97 ? c -= 97 : c -= 65;  // calculating the index for storing in carr using ascii values
                        carr[c] +=1;  // incremented the value at the index corresponding to the alphabet
                    }
                    else carr[26] +=1;  // otherwise incremented for 26th index for special character
                    k = i;
                }
                k++;
                Console.Write("The Number of Duplicate Characters in Word " + cnt + " : "); // Printed the Word Number
                cnt++;
                for (int j = 0; j < 27; j++)
                {
                    if (carr[j]>1 && j != 26) // checking which aplhabet occured more than one
                    {
                        Console.Write((char)(j + 65) + " ");   // and printing them
                        carr[j] = 0;  // re-initializing with 0 for the use of next word in the string
                    }
                    if (carr[j]==1) { carr[j] = 0; } // re-initialization for character occured only once 
                    if (carr[j]>1 && j == 26)
                    { // if speical character is also present 
                        Console.Write("Special Character"); // then informing that special characters are also present
                        carr[26] = 0;
                    }

                }
                Console.WriteLine();
            }
            else k++;
        }


    }


    public void dupChar2(StringBuilder sb) { //P23 - Characters having  duplicates in the whole string with special characters
        bool exist = false; // variable for know whether another same character exists or not
        Console.Write("Duplicate Characters: ");
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == ' ') continue;
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[i] == sb[j]) // if not the same character and duplicate then exist is true 
                {
                    sb[j] = ' ';
                    exist = true;
                }


            }
            if (exist) Console.Write(sb[i] + " ");  // if duplicate exist print
            exist = false;  // re-initializing for next iteration
        }
        Console.WriteLine();

    }




    public StringBuilder InttoRoman(int n)  // P24-Converting number to standard Roman numeral system which starts from 1 and ends at 3999.
    {
        StringBuilder sb = new StringBuilder("");
        int r = 0;
        if (n <= 0 || n >= 4000)
        {
            Console.WriteLine("Number doesn't exist in Roman Numeral System !"); return sb;
        }
        else
        {
            if (n >= 1000 && n <= 3999)
            {
                r = n / 1000;
                n %= 1000;
                while (r > 0) { sb.Append("M"); r--; }
            }
            if (n <= 999 && n >= 900)
            {
                n %= 100;
                sb.Append("CM");
            }
            if (n <= 899 && n >= 500)
            {
                r = n / 100;
                r -= 5;
                n %= 100;
                sb.Append("D");
                while (r > 0) { sb.Append("C"); r--; }
            }
            if (n <= 499 && n >= 400)
            {
                n %= 100;
                sb.Append("CD");
            }
            if (n <= 399 && n >= 100)
            {
                r = n / 100;
                n %= 100;
                while (r > 0) { sb.Append("C"); r--; }
            }
            if (n <= 99 && n >= 90)
            {
                n %= 10;
                sb.Append("XC");
            }
            if (n <= 89 && n >= 50)
            {
                r = n / 10;
                r -= 5;
                n %= 10;
                sb.Append("L");
                while (r > 0) { sb.Append("X"); r--; }
            }
            if (n <= 49 && n >= 40)
            {
                n %= 10;
                sb.Append("XL");
            }
            if (n <= 39 && n >= 10)
            {
                r = n / 10;
                n %= 10;
                while (r > 0) { sb.Append("X"); r--; }
            }
            if (n == 9) { sb.Append("IX"); }
            if (n <= 8 && n >= 5)
            {
                n -= 5;
                sb.Append("V");
                while (n > 0) { sb.Append("I"); n--; }
            }
            if (n == 4) sb.Append("IV");
            if (n <= 3 && n >= 1)
            {
                while (n > 0)
                {
                    sb.Append("I"); n--;
                }
            }

            return sb;
        }
    }




    public void LLRpNumTriPttrn(int n) //P25 - Lower Left Repeated Numbered Triangular Pattern
    {
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }


    public void RLLRpNumTriPttrn(int n) //P26- Reversed Lower Left Repeated Numbered Triangular Pattern
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }



    public void LLNumTriPttrn(int n) //P27- Lower Left Numbered Triangular Pattern [Non-repeated number]
    { int ln = 1;
        int i = 1;
        while(ln<=n) {
            int li = i;
            for (int j = i; j < ln+li; j++)
            {
                Console.Write(j + " ");
                i++;
            }
            ln++;
            Console.WriteLine();
                }
    }


    public void LLSqnBinTriPttrn(int n) //P28 - Lower Left Squential Binary Triangular Pattern
    {
        int i,j, ln = 1;
       while(ln<=n)
        {
            j = 1; i = ln % 2;
            while(j<=ln)
            {
                Console.Write(i + " ");
                i=i != 0 ?  0 :  1;
                j++;
            }
            Console.WriteLine();
            ln++;
        }
    }



    public void LPyrRpNum(int n)  //P29 - Left Pyramid of Repeated Numbers 
    {
        int i, j, ln=1;
        while (ln<2*n)
        { i = 1;
            while (i <= ln)
            {   if (ln <= n || i <= 2 * n - ln) Console.Write(i + " ");
                i++;
            }  ln++;
            Console.WriteLine();
        }
    }




    public void CLPyrRpNum(int n) //P30- Complement of Left Pyramid of Repeated Numbers
    {
        int i, j=n, ln = 1;
        while (ln < 2 * n)
        {
            i = 1;
            while (i <= j)
            {
                Console.Write(i + " ");
                i++;
            }
            ln++;
            if(ln<=n)j--;
            if (ln > n) j++;
            Console.WriteLine();
        }
    }

    public void PyrRpNum(int n)  //P31 - Pyramind with Repeated Numbers [Pyramind is made on bottom as base]
    {
        int i,j,ln = 1;
        while (ln <= n)
        {
            i = 1;
             j = 1;
            while (i<2*n)
            {
                if (i > n - ln && i<n) { Console.Write(j);  j++; }
                if(i==n) { Console.Write(j); j--;  }
                if (i < n + ln && i>n) { Console.Write(j); j--; }
                if(i<=n-ln || i>=n+ln) Console.Write(" ");
                i++;
                
            }
            Console.WriteLine();
            ln++;
        }

    }



    public void PyrCalcPttrn(int n)  //P32- Pyramid pattern where pyramid border is made from 1's and inside numbers are sum of above two number in between the current one will be
                                     //my logic using one-D array of size equal to no of rows
    {
        int ln=1,j, nt=1,t,i; int[] arr = new int[n];
        arr[0] = 1;
        while (ln <= n)   // till the current line number reaches the number of rows
        {
            nt = 1;
            for(int k = 1; k < ln; k++)   // calculating the values that needs to be filled in the current line number
            { t = arr[k];
                arr[k] +=nt;
                nt = t;
            }
            
            i = 1;j = 0;
            while (i < 2 * n)
            { 
                if (i >=n - ln + 1 && i <= n + ln - 1) {    // comparing the i with the correct place/index where the value should be printed
                    
                    if ((n%2==0 && ln % 2 != i % 2) || (n%2!=0 && ln%2==i%2) )   // indexes where spaces dont have to be there only the numeric values
                    {
                        if (arr[j] < 10 && arr[j]>0) Console.Write("0" + arr[j]);
                        else Console.Write(arr[j]);
                        j++;
                    }
                    else Console.Write("  ");  // rest for spaces between the range of the current line of pyramid
                    
                }
                else { Console.Write("  "); }  // spaces outside for the range of current line of pyramid

                i++;
            }
                ln++;
            Console.WriteLine();
        }
    }



    public void PyrCalcPttrn2(int n)   //P32- Sir's logic
    {
        int res;
        for(int i = 0; i <= n; i++)
        {
            res = 1;
            for (int j = i; j <= n - 1; j++) Console.Write(" ");  // pringting spaces starting from line number till the no of rows-1
            for (int k=0;k<=i;k++)
            {
                Console.Write(res+" ");   // printing result just after above spaces till the k count reach the line number 
                res = res* (i - k) / (k + 1);
                //res *= (i - k) / (k + 1);  // gives wrong result may be beacuase here first divison is getting calculated and due to interger values, it may give not exact results 
            }
            Console.WriteLine();
        }
    }




    public void Diamond(int n)  //P33-Printing diamond with n as half of the number of rows+1
    { int ln = 1; bool f = false;
        while (ln > 0) {
            if (ln == n) f = true;
            for (int i = 0; i < n - ln;i++) Console.Write(" ");  // printing the spaces before printing *
            for (int i = 0; i < (2 * ln - 1); i++) Console.Write("*"); // then printing the required stars
            if (ln < n && !f) ln++; // increasing till the middle row
            
            if (f) ln--; // then decreasing till 0 and loop will break
            Console.WriteLine();

} }



    public void OrthoTrapz(int n)  //P34- Printing the Orthogonal Trapezium- my logic
    {
        int i, ln = 1;
        while (ln <= n)  // runs till the row number
        {  i = 1;
            while (i <(2*ln+1)) { if (i!=ln) { Console.Write("*"); i++; } 
                else if (i == ln) { Console.Write("* "); i++; }
            }
            ln++;
            Console.WriteLine();
        }
    }

    public void OrthoTrapz2(int n)  //P34- Printing the Orthogonal Trapezium- sir's logic
    {
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++) Console.Write("*");
            Console.Write(" ");
            for (int j = 0; j <= i; j++) Console.Write("*");
            Console.WriteLine();
        }

    }



    public void PrntStrRect(int l, int b)   //P35- Printing the Rectangle with stars
    {
        for(int i = 1; i <= l; i++)   // running till length
        { 
            for(int j = 1; j <= b; j++)  // running till breadth
            {
                if (i == 1 || i == l || j == 1 || j == b) Console.Write("* ");  // if the border print star, given space just for clear output
                else Console.Write("  ");  // if indor / else print two spaces coz above I printed star with spaces for clear ouput
            }
            Console.WriteLine();
        }
    }


    public void BubbleSort(int[] arr) //P36-Moving the maximum element at the end and in next iteration till the n-1 and so on
    {
        int temp;
        bool swp = false;
        for(int i = 0; i < arr.Length; i++)  
        {
            for(int j = 0; j < arr.Length-i-1; j++) // Going till the array is unsorted using length-i-1
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;  
                    swp= true; 
                }
            }
            if (!swp) {
                Console.WriteLine(" Now Already sorted !");
                break; }
        }
    }


    public void SelectionSort(int[] arr) //P37- finding the minimum and then replacing with the ith element in the ith iteration
    {
        int min,temp;
        for(int i = 0; i < arr.Length - 1; i++)
        { min = i;
            for(int j = i + 1; j < arr.Length ; j++)
            {
                if (arr[j] < arr[min]) min = j;
            }
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }

    }


    public void InsertionSort(int[] arr) //P38- Sorting from from 0 till i+1 but backwards in ith iteration
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;

                }
                else break;
            }
        }
    }


    public void InsertionSort2(int[] arr) //P38- second for loop for above code is replace with while- popular code for insertion sort
    {
        int key;
        for (int i = 0; i < arr.Length; i++)
        {
            key = arr[i];
            while (i > 0 && arr[i - 1] > key)
            {
                arr[i] = arr[i - 1];
                i--;
            }
            arr[i] = key;
        }
    }



    public void ShellSort(int[] arr) //P39- Checking from i+gap and going forward and using traditional swap
    { int n = arr.Length,temp;
        int gap = n / 2;
        while (gap >= 1)
        {
            for (int i = 0; i+gap < n; i++)
            {
                int j = i+gap;
                while(j<n) {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
                    j += gap;
            }
            }
            gap /= 2;
        }
    }


    public void ShellSort2(int[] arr) //P39-Checking from i+gap and going backwards and first checking all elements with gap then placing it, instead of swapping it everytime like above
    {
        int n = arr.Length,temp;
        int gap = n / 2;
        while (gap > 0)
        {
            for(int i = 0; i + gap < n; i++)
            {
                int j = i + gap;
                temp = arr[j];
                while (j -gap>=0 && temp < arr[j-gap])
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }
                arr[j] = temp;
            }
            gap /= 2;
        }
    }


    public int partition(int[] arr,int l, int h) //P40- Partition algo that will be used for partitioning the array based on the pivot
    {
        int i = l + 1, temp, j = h, pivot;
        pivot = arr[l];
        while (i < j)
        {
            while (pivot >= arr[i]) i++;
            while (pivot < arr[j]) j--;
            if (i < j) { temp = arr[i]; arr[i] = arr[j]; arr[j] = temp; }
        }
        temp = arr[j];
        arr[j] = arr[l];
        arr[l] = temp;
        return j;
    }
    public void QuickSort( int[] arr,int l, int h) //P40- QuickSort function that will divide the array from the parition index and sort independently.
    {
        int j;
        if (l < h)
        {
            j = partition(arr, l, h);
            QuickSort( arr, l, j - 1);
            QuickSort(arr, j + 1, h);
        }

    }



   

}

