class Solution:
    def isValid(self, s: str) -> bool:
        if "()" in s:
            return True
        if "{}" in s:
            return True
        if "[]" in s:
            return True
        return False


def main():
    sol1 = Solution()
    e = "(]"
    result = sol1.isValid(e)
    print(result)


if __name__ == "__main__":
    main()
