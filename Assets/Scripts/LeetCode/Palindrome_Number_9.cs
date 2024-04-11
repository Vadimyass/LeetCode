using UnityEngine;

namespace LeetCode
{
    public class Palindrome_Number_9
{
    public bool IsPalindrome(int x)
    {
        var localList = x.ToString();
        var locallistLenght = localList.Length;
        if (locallistLenght % 2 == 0)
        {
                for (int i = 0; i <= locallistLenght / 2; i++) 
                {
                    if (localList[i] == localList[locallistLenght - 1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        Debug.LogError(localList[i] + "and" + localList[locallistLenght - 1 - i] + "are not equals");
                        return false;
                    }
                }
             Debug.LogError("Success");
            return true;

        }
        else
        {
            for (int i = 0; i < locallistLenght / 2; i++)
            {
                if (localList[i] == localList[locallistLenght - 1 - i])
                {
                    continue;
                }
                Debug.LogError(localList[i] + "and" + localList[locallistLenght - 1 - i] + "are not equals");
                return false;
            }

            Debug.LogError("Success");
            return true;
        }
    }
}
}