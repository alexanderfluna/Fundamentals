package java.data_structures.Map;
import java.util.HashMap;
import java.util.Map;

class TwoSum {
    public static int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> numToIndex = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            
            if (numToIndex.containsKey(complement)) {
                int complementIndex = numToIndex.get(complement);
                return new int[]{complementIndex, i};
            }

            numToIndex.put(nums[i], i);
        }

        throw new IllegalArgumentException("No two numbers add up to the target sum.");
    }

    public static void main(String[] args) {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        int[] result = twoSum(nums, target);
        System.out.println("Indices of the two numbers that add up to " + target + ": " + result[0] + ", " + result[1]);
    }
}