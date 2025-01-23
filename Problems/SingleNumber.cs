﻿namespace Problems;

public class SingleNumber
{
    public int GetSingleNumber(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++) {
            result ^= nums[i];
        }

        return result;
    }
}
