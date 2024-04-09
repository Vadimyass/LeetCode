using System;
using UnityEngine;

namespace LeetCode
{
    public class LeetCodeStarter : MonoBehaviour
    {
        private void Start()
        {
            var massiv = new int[]
            {
                3,2,4
            };
            new Solution1().TwoSum(massiv, 6);
        }
    }
}