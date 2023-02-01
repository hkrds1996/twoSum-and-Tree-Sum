public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> set = new HashSet<int>();
        Dictionary<int,int> dictionary = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; ++i){
            if(set.Contains(target-nums[i])){
                return new int[]{dictionary[target-nums[i]],i};
            }
            dictionary[nums[i]] = i;
            set.Add(nums[i]);
        }
        return new int[]{};
    }
}