public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        Dictionary<int,int> dict = new Dictionary<int,int>();
        List<IList<int>> result = new List<IList<int>>();
        for(int i = 0; i < nums.Length-2; ++i){
            if(i-1>=0&&nums[i-1]==nums[i]){
                continue;
            }
            int leftPoint = i+1;
            int rightPoint = nums.Length-1;
            int currTarget = -nums[i];        
            while(leftPoint<rightPoint){
                if(nums[leftPoint]+nums[rightPoint]==currTarget){
                    List<int> currSub = new List<int>();
                    currSub.Add(nums[i]);
                    currSub.Add(nums[leftPoint]);
                    currSub.Add(nums[rightPoint]);
                    result.Add(currSub);
                    leftPoint++;
                    while(leftPoint<rightPoint&&nums[leftPoint-1]==nums[leftPoint]){
                        leftPoint++;
                    }
                }else if(nums[leftPoint]+nums[rightPoint]>currTarget){
                    rightPoint --;
                }else{
                    leftPoint ++;
                }
            }
        }
        return (IList<IList<int>>)result;

    }
}