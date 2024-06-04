class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        // Array of size 255 initialized with -1 (ASCII)
        int hash[255];
        memset(hash,-1,sizeof(hash));
        // Get the size of the input string
        int n = s.size();
        // Initialize pointers for the sliding window
        int left = 0;
        int right = 0;
        // Initialize variable to store the maximum length of substring without repeating characters
        int max_length = 0;
        
        // Loop until the right pointer reaches the end of the string
        while(right < n) {  
            // If the current character is already in the substring 
            // and its index is within the current window, update the left pointer
            if(hash[s[right]] != -1 && hash[s[right]] >= left)
                left = hash[s[right]] + 1;
            
            int length = right - left + 1; // Calculate the length of the current substring
            max_length = max(max_length, length); // Update the maximum length
            hash[s[right]] = right;  // Store the index of the current character in the hash table
            right++; // Move the right pointer to the next character
        }
        return max_length;
    }
};
