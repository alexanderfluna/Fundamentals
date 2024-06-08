class Solution {
public:
    // XOR
    int singleNumber(vector<int>& nums) {
        int ans = 0;
        for (int i = 0; i < nums.size(); i++){
            ans ^= nums[i];
        }
        return ans;
    }

    
    /*
    // Sorting
    int singleNumber(vector<int>& nums) {
        std::sort(nums.begin(), nums.end());
        
        for (int i = 1; i < nums.size() ; i+=2)
            if (nums[i] != nums[i-1]) return nums[i-1];
        
        return nums[nums.size() - 1];
    }
    */
};