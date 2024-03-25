public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
          int tempvar = nums[i];
          nums[i] = 0 ;
          if(nums.Contains(tempvar))
          {
            result.Add(tempvar);
          }
        }
        return result;
    }
}