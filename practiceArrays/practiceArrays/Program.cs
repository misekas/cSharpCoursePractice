using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = 123455;
        GenerateNumber(number);
        Console.ReadLine();
    }

    static void GenerateNumber(int number)
    {
        int arrayNumber = number;
        for (int i = 99999; i < 999999; i++)
        {
          arrayNumber++;
          NumberToArray(arrayNumber);
        }
    }

    static void NumberToArray(int arrayNumber)
    {
        string stringNumber = Convert.ToString(arrayNumber);

        int[] membertoArray = new int[6];

        for (int i = 0; i < stringNumber.Length; i++)
        {
            membertoArray[i] = int.Parse(Convert.ToString(stringNumber[i]));
            //Console.WriteLine(membertoArray[i]);
        }
        CheckAreMembersDifferentInNumber(membertoArray);
        //Console.ReadLine();
    }

    static void CheckAreMembersDifferentInNumber(int[] membertoArray)
    {
        int[] isMembersDifferent = membertoArray.Clone() as int[];
     // pameginti su for
        if (isMembersDifferent[0] != isMembersDifferent[1] && isMembersDifferent[0] != isMembersDifferent[2] && isMembersDifferent[0] != isMembersDifferent[3] && isMembersDifferent[0] != isMembersDifferent[4] && isMembersDifferent[0] != isMembersDifferent[5])
        {
             if (isMembersDifferent[1] != isMembersDifferent[2] && isMembersDifferent[1] != isMembersDifferent[3] && isMembersDifferent[1] != isMembersDifferent[4] && isMembersDifferent[1] != isMembersDifferent[5])
            {
                 if (isMembersDifferent[2] != isMembersDifferent[3] && isMembersDifferent[2] != isMembersDifferent[4] && isMembersDifferent[2] != isMembersDifferent[5])
                {
                     if (isMembersDifferent[3] != isMembersDifferent[4] && isMembersDifferent[3] != isMembersDifferent[5])
                    {
                         if (isMembersDifferent[4] != isMembersDifferent[5])
                        {
                            string joinMembers = string.Join("", isMembersDifferent);
                            NumberMultiply(joinMembers);
                            Console.WriteLine(isMembersDifferent);
                        }
                    }
                }
            }
        }

    }

    static void NumberMultiply(string joinMembers)
    {
        int multiplyNumber = Convert.ToInt32(joinMembers);
        int multiply2 = multiplyNumber * 2;
        int multiply3 = multiplyNumber * 3;
        int multiply4 = multiplyNumber * 4;
        int multiply5 = multiplyNumber * 5;
        int multiply6 = multiplyNumber * 6;
        MultiplyedNumberToArray(multiply2, multiply3, multiply4, multiply5, multiply6);
    }

    static void MultiplyedNumberToArray(int multiply2 , int multiply3, int multiply4, int multiply5, int multiply6)
    {
        int[] multiplyedToArray = new int[5] { multiply2 , multiply3, multiply4, multiply5, multiply6 };
        foreach (int item in multiplyedToArray)
        {
            string stringMultiplyedNumber = Convert.ToString(item);

            int[] multiplyedMembertoArray = new int[6];
            for (int i = 0; i < stringMultiplyedNumber.Length; i++)
            {
                multiplyedMembertoArray[i] = int.Parse(Convert.ToString(stringMultiplyedNumber[i]));
            }
           // CheckArraysMembers(multiplyedMembertoArray);
        }
    }

    //static bool CheckArraysMembers( int[] multiplyedMembertoArray)
    //{
    //    if (membertoArray.SequenceEqual(multiplyedMembertoArray))
    //    {
    //        return true;
    //    }
    //    return false;
    //}
}


