using System;

namespace TDDArg
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            int rob = 0;
            int notRob = 0;

            foreach (var num in nums)
            {
                var currentRob = notRob + num;
                notRob = Math.Max(rob, notRob);
                rob = currentRob;
            }

            return Math.Max(rob, notRob);
        }
    }
}