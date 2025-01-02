namespace Problems;

public class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;

        for (var i = nums1.Length - 1; i >= 0; i--)
        {
            if (p1 < 0 || p2 < 0)
            {
                if (p1 < 0)
                {
                    nums1[i] = nums2[p2];
                    p2--;
                }
                else if (p2 < 0)
                {
                    nums1[i] = nums1[p1];
                    p1--;
                }
            }
            else
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[i] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[i] = nums2[p2];
                    p2--;
                }
            }
        }
    }
}
