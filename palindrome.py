
class Solution:
    def isPalindrome(self, x: int) -> bool:
        replica = x
        if x < 0:
            return False
        revs_x = 0
        while(x > 0):
            remainder = x % 10
            revs_x = (revs_x * 10) + remainder
            x = x//10
        return revs_x == replica


def main():
    x = 121
    sol1 = Solution()
    result = sol1.isPalindrome(x)
    print(result)


if __name__ == "__main__":
    main()
