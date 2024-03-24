public class Solution {
    public int FindDuplicate(int[] nums) {
        for(int i = 0 ; i < nums.Length ; i++)
        {
          int[] temp = nums;
          int tempvar = temp[i];
          temp[i] = 0 ;
          if(temp.Contains(tempvar))
          {
            return tempvar;
          }
        }
     return 0;
    }
}