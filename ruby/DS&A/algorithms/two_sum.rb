def two_sum(nums, target)
  num_indices = {}

  nums.each_with_index do |num, index|
    complement = target - num

    if num_indices.key?(complement)
      return [num_indices[complement], index]
    end

    num_indices[num] = index
  end

  return nil
end

nums = [2, 7, 11, 15]
target = 9
puts two_sum(nums, target)
