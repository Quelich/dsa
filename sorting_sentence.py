def sortSentence(s: str) -> str:
    s = s.split(" ")
    d = {}
    for string in s:
        print("String: {} with last element: {}".format(string, string[len(string) - 1]))
        index = int(string[len(string) - 1])
        d[index] = string[0:int(len(string) - 1)]
    s = ""
    for i in sorted(d):
        if i != len(d):
            s += d[i] + " "
    s += d[len(d)]
    return s


input = "is2 sentence4 This1 a3"
print(sortSentence(input))
