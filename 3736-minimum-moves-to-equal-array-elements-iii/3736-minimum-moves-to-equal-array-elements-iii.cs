public class Solution {
    public int MinMoves(int[] nums)
    {
        int sayac = 0, max = nums.Max();
        foreach (var fark in nums)
        {
            sayac += (max - fark);
        }
        return sayac;
    }
}