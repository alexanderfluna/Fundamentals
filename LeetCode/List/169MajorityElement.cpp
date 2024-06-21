class Solution {
public:
    // Map 
    int majorityElement(vector<int>& nums) {
        int n = nums.size();
        unordered_map<int, int> map;
        
        for (int i = 0; i < n; i++)
            map[nums[i]]++;
        
        n = n/2;
        
        for (auto x : map)
        {
            if (x.second > n)
                return x.first;
        }
        
        return 0;
    } 
    
    /*
    // Moore Voting Algorithm
    int majorityElement(vector<int>& nums) {
        int candidate = nums[0];
        int count = 1;
        
        for (int i = 1; i < nums.size(); i++)
        {
            if (count  == 0) candidate = nums[i];       
            count += (candidate == nums[i]) ? 1 : -1;
        }
        
        return candidate;
    }
    */
};