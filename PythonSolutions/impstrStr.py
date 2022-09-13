class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        if needle in haystack:
            i = haystack.index(needle)
            return i
        if needle == "":
            return 0
        return -1



def main():
    sol1 = Solution()
    haystack = "hello"
    needle = "ll"
    result = sol1.strStr(haystack, needle)
    print(result)


if __name__ == "__main__":
    main()
