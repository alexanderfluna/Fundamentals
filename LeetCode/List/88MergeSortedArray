class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        i = m - 1 # points to last non-zero digit in nums1
        j = n - 1 # points to last index in nums2
        k = m + n - 1 # points to last index in nums1
        
        # Iterate through the lists
        while i>= 0 and j >= 0:
            
            # If the current digit in nums1 is greater than the current digit in nums2
            if nums1[i] > nums2[j]:
                
                # Replace one of the 0s at the end of the list with the current digit in nums1
                nums1[k] = nums1[i]
                
                # Go to the next digit to the left in nums1
                i -= 1
                
            # If the current digit in nums1 is less than or equal to the current digit in nums2
            else:
                
                # Replace one of the 0s at the end of the list with the current digit in nums2
                nums1[k] = nums2[j]
                
                # Go to the next digit to the left in nums2
                j -= 1
                
            # Go to the next 0 to the left at the end of nums1
            k -= 1
            
        # If there are any remaining digits in nums2
        while j >= 0:
            
            # Replace one of the 0s at the end of the list with the current digit in nums2
            nums1[k] = nums2[j]
            
            # Go to the next digit to the left in nums2
            j -= 1

            # Go to the next 0 to the left at the end of nums1
            k -= 1
        
