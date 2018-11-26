using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = 100000;
        GenerateNumber(number);
        Console.ReadLine();
    }

    static void GenerateNumber(int number)
    {
        int arrayNumber = number;
        for (int i = 0; i < 999999; i++)
        {
            arrayNumber++;
            if (arrayNumber > 999999)
            {
                break;
            }
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
        }
        CheckAreMembersDifferentInNumber(membertoArray);
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
                            NumberMultiply(joinMembers, membertoArray);
                        }
                    }
                }
            }
        }

    }

    static void NumberMultiply(string joinMembers, int[] membertoArray)
    {
        int multiplyNumber = Convert.ToInt32(joinMembers);
        int multiply2 = multiplyNumber * 2;
        if (multiply2 < 999999)
        {
            int multiply3 = multiplyNumber * 3;
            if (multiply3 < 999999)
            {
                int multiply4 = multiplyNumber * 4;
                if (multiply4 < 999999)
                {
                    int multiply5 = multiplyNumber * 5;
                    if (multiply5 < 999999)
                    {
                        int multiply6 = multiplyNumber * 6;
                        if (multiply6 < 999999)
                        {
                            MultiplyedNumberToArray(multiply2, multiply3, multiply4, multiply5, multiply6, membertoArray);
                        }
                    }
                }
            }
        }
    }

    static void MultiplyedNumberToArray(int multiply2, int multiply3, int multiply4, int multiply5, int multiply6, int[] membertoArray)
    {
        int[] multiplyedToArray = new int[5] { multiply2, multiply3, multiply4, multiply5, multiply6 };
        foreach (int item in multiplyedToArray)
        {
            string stringMultiplyedNumber = Convert.ToString(item);

            int[] multiplyedMemberToArray = new int[6];
            for (int i = 0; i < stringMultiplyedNumber.Length; i++)
            {
                multiplyedMemberToArray[i] = int.Parse(Convert.ToString(stringMultiplyedNumber[i]));
            }
            if (!CheckArraysMembers(multiplyedMemberToArray, membertoArray))
            {
                return;
            }
        }
        Console.WriteLine(string.Join("", membertoArray));
    }

    static bool CheckArraysMembers(int[] multiplyedMemberToArray, int[] membertoArray)
    {
        int[][] arrayNumberSources = new int[][] { membertoArray, multiplyedMemberToArray };
        if (membertoArray[0] != multiplyedMemberToArray[0])
        {
            if (membertoArray[0] != multiplyedMemberToArray[1])
            {
                if (membertoArray[0] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[0] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[0] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[0] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        if (membertoArray[1] != multiplyedMemberToArray[0])
        {
            if (membertoArray[1] != multiplyedMemberToArray[1])
            {
                if (membertoArray[1] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[1] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[1] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[1] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        if (membertoArray[2] != multiplyedMemberToArray[0])
        {
            if (membertoArray[2] != multiplyedMemberToArray[1])
            {
                if (membertoArray[2] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[2] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[2] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[2] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        if (membertoArray[3] != multiplyedMemberToArray[0])
        {
            if (membertoArray[3] != multiplyedMemberToArray[1])
            {
                if (membertoArray[3] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[3] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[3] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[3] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        if (membertoArray[4] != multiplyedMemberToArray[0])
        {
            if (membertoArray[4] != multiplyedMemberToArray[1])
            {
                if (membertoArray[4] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[4] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[4] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[4] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        if (membertoArray[5] != multiplyedMemberToArray[0])
        {
            if (membertoArray[5] != multiplyedMemberToArray[1])
            {
                if (membertoArray[5] != multiplyedMemberToArray[2])
                {
                    if (membertoArray[5] != multiplyedMemberToArray[3])
                    {
                        if (membertoArray[5] != multiplyedMemberToArray[4])
                        {
                            if (membertoArray[5] != multiplyedMemberToArray[5])
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        string joinMembers = string.Join("", membertoArray);
        //Console.WriteLine(joinMembers);
        return true;
    }

}


