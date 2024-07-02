class Solution {                      
public:
    int reverse(int x) {
        int reverse = 0;
        
        while(x)
        {
        // Check 32-bit range. If reverse is outside the range then return 0 
         if ( reverse > INT_MAX / 10 || reverse < INT_MIN / 10) return 0; 
         reverse = reverse*10 + x%10; // find remainder and add its to r
         x = x/10;     // Update the value of x
        } 
        
        return reverse;  // if r in the 32 bit range then return r
    }
}; 