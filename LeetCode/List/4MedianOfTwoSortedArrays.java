class Solution {
    private int p1 = 0, p2 = 0;

    // Get the smaller value between nums1[p1] and nums2[p2] and move the pointer forwards.
    private int getMin(int[] nums1, int[] nums2) {
        
        // If neither of the pointers have reached the end of their arrays
        if (p1 < nums1.length && p2 < nums2.length) {
            
            // Return the nums1 pointer if it is less than the nums2 pointer, else return the nums2 pointer
            // Increment the nums1 and nums2 pointer
            return nums1[p1] < nums2[p2] ? nums1[p1++] : nums2[p2++];
        }
        
        // If p1 has not reached the end of nums1
        else if (p1 < nums1.length) {
            
            // Return the nums1 pointer and increment it
            return nums1[p1++];
        } 
        
        // If p2 has not reached the end of nums2
        else if (p2 < nums2.length) {
            
            // Return the nums2 pointer and increment it
            return nums2[p2++];
        }
        return -1;
    }

    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        // Get the size of the arrays
        int m = nums1.length, n = nums2.length;
        
        // If the the size of both arrays combined is even
        if ((m + n) % 2 == 0) {
            
            // Iterate until you reach the index of the median of the two arrays
            for (int i = 0; i < (m + n) / 2 - 1; ++i) {
                
                // Increment the pointers until we reach the index of the median of the two arrays
                int tmp = getMin(nums1, nums2);
            }
            
            // Return the median
            return (double) (getMin(nums1, nums2) + getMin(nums1, nums2)) / 2;
        } 
        
        // If the size of both arrays combined is odd
        else {
            
            // Iterate until you reach the index of the median of the two arrays
            for (int i = 0; i < (m + n) / 2; ++i) {
                
                // Increment the pointers until we reach the index of the median of the two arrays
                int tmp = getMin(nums1, nums2);
            }
            
            // Return the median
            return getMin(nums1, nums2);
        }
    }
}