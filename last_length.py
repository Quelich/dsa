class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        words = s.split()
        if len(words) > 0:
            return len(words[len(words) - 1])
        if " " in s:
            if len(words) > 0:
                return len(words[len(words) - 1])
        return 0


def main():
    sol1 = Solution()
    s = "a"
    result = sol1.lengthOfLastWord(s)
    print(result)


if __name__ == "__main__":
    main()
