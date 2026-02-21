alphabet = [
    [11, 'A'], [12, 'B'], [13, 'C'], [14, 'D'], [15, 'E'],
    [21, 'F'], [22, 'G'], [23, 'H'], [24, 'I'], [25, 'K'],
    [31, 'L'], [32, 'M'], [33, 'N'], [34, 'O'], [35, 'P'],
    [41, 'Q'], [42, 'R'], [43, 'S'], [44, 'T'], [45, 'U'],
    [51, 'V'], [52, 'W'], [53, 'X'], [54, 'Y'], [56, 'Z']
]

data = input("Введите текст или шифр: ")
result = ""
if (data[0].isdigit()):
    for i in range(0, len(data)-1, 2):
        symbol = int(data[i]+data[i+1])
        for i in alphabet:
            if (i[0] == symbol):
                result += i[1]
else:
    for letter in data:
        for i in alphabet:
            if (i[1] == letter):
                result += str(i[0])

print(result)
