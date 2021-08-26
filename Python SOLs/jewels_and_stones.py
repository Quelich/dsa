class Solution:
    def numJewelsInStones(self, jewels: str, stones: str) -> int:
        counter = 0
        jewel_types = list(jewels)
        stone_types = list(stones)
        for stone in stone_types:
            for jewel in jewel_types:
                if stone == jewel:
                    counter += 1
        return counter
        
        

def main():
    jewels = "z"
    stones = "ZZ"
    sol = Solution()
    result = sol.numJewelsInStones(jewels, stones)
    print(result)
    


if __name__ == "__main__":
    main()
