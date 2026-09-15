class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        a = set(nums)
        return True  if len(a) < len(nums) else  False 
        