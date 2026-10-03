class Solution(object):
    def twoSum(self, nums, target):
        n = len(nums)
        for i in range(len(nums)):
            for j in range(i + 1, n):
                if nums[i] + nums[j] == target:
                    return [i,j]