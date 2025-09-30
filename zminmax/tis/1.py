input_values = input('Введите a, b, c: ').split()
a, b, c = int(input_values[0]), int(input_values[1]), int(input_values[2])
if (len([a, b, c]) != 3):
    print('Неверные входные данные')

discriminant = b**2 - 4*a*c
result = ''



if (a==0 and b==0 and c==0):
    print('бесконечно много решений')
if (a==0 and b==0):
    print('нет решений')
if (a==0):
    print('линейное уравнение')
    print('x = ', -c/b)
else:
    if (discriminant < 0):
        print('комплексные корни')
        print(f"x1 = {-b} + i*{round(abs(discriminant)**0.5, 2)} / {2*a} \nx2{-b} - i*{round(abs(discriminant)**0.5, 2)} / {2*a}")
    if (discriminant == 0):
        print('действительный корень')
        print(-b/(2*a))
    if (discriminant > 0):
        print('два действительных корня')
        print(f"x1 = {-b + discriminant**0.5/ 2 * a}\nx2 = {-b - discriminant**0.5/ 2 * a}")

