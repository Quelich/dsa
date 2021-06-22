from typing import List
class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        result = []
        for i in range(0,len(nums)):
            counter = 0
            for j in range(0,len(nums)):
                if nums[i] > nums[j]:
                    counter += 1
            result.append(counter)
        return result


def main():
   nums = [8,1,2,2,3]
   sol1 = Solution()
   result = sol1.smallerNumbersThanCurrent(nums)
   print(result)
if __name__ == "__main__":
    main()
