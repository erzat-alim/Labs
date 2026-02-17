try:
    a, b, c = [int(i) for i in input('Enter your parameters: ').split()]
except:
    print('Invalid input')
    exit()

D = b**2 - 4*a*c
result = ''



if (a==0 and b==0 and c==0):
    result = ['infinitely many solutions']
elif (a==0 and b==0):
    result = ['no solutions']
elif (a==0):
    result = [-c/b]
else:
    if (D < 0):
        result = [f"{-b} + i*{round(abs(D)**0.5, 2)} / {2*a}", f"{-b} - i*{round(abs(D)**0.5, 2)} / {2*a}"]
    elif (D == 0):
        result = [-b / 2 * a]
    else:
        result = [-b + D**0.5/ 2 * a, -b - D**0.5/ 2 * a]

if (len(result) > 1):
    print(f"x1 = {result[0]}\nx2 = {result[1]}")
else:
    print(f"x = {result[0]}")
