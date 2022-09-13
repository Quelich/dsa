class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        main_str = ""
        for str in strs:
            main_str += str + "|"
        while main_str.find("|") != -1:
            main_str = main_str.replace("|", "")
            if main_str in strs:
                break
            else:
                main_str = main_str[:-1]


def main():
    sol1 = Solution()


if __name__ == "__main__":
    main()
