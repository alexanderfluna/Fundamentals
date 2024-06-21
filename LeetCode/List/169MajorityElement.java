class Solution {
    // HashMap
    public int majorityElement (int[] nums) {
        int n = nums.length;
        Map<Integer, Integer> map = new HashMap<>();
        
        for (int i = 0; i < n; i++)
        {
            map.put(nums[i], map.getOrDefault(nums[i], 0) + 1);
        }
        
        n = n/2;
        
        for (var entry : map.entrySet())
        {
            if (entry.getValue() > n)
                return entry.getKey();
        }
        
        return 0;
    }
    
    /*
    // Moore Voting Algorithm
    public int majorityElement(int[] nums) {
        int candidate = nums[0];
        int count = 1;
        
        for (int i = 1; i < nums.length; i++)
        {
            if (count == 0) candidate = nums[i];
            count += (nums[i] == candidate) ? 1 : -1;
        }
        
        return candidate;
    }
    */
}