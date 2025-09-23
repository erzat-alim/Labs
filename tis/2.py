import math

def clean_complex(z, eps=1e-10):
    real = z.real
    imag = z.imag
    
    if abs(imag) < eps:
        imag = 0.0
    if abs(real) < eps:
        real = 0.0
    
    return complex(real, imag)

def print_roots(roots):
    for i, root in enumerate(roots):
        if abs(root.imag) < 1e-10:
            print(f"x{i+1} = {root.real:.6f}")
        else:
            print(f"x{i+1} = {root.real:.6f} {('+' if root.imag >= 0 else '')}{root.imag:.6f}i")

try:
    a, b, c, d = [int(i) for i in input('Enter parameters: ').split()]
except:
    print('Invalid input')
    exit()

eps = 1e-10

if (abs(a) < eps):
    a = b
    b = c
    c = d
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
else:
    A = b / a
    B = c / a
    C = d / a

    p = B - A**2/3.0
    q = C + (2*(A**3) - 9*A*B)/27.0

    D = (q**2/4.0) + (p**3/27.0)

    if (d > eps):
        u = -q/2.0 + math.sqrt(D)
        v = -q/2.0 - math.sqrt(D)

        u = u**(1/3) if u>=0 else -((u)**(1/3))
        v = v**(1/3) if v>=0 else -((v)**(1/3))

        y1 = 2*u
        y2 = complex(-(u+v)/2, (u-v)*math.sqrt(3)/2)
        y3 = complex(-(u+v)/2, -(u-v)*math.sqrt(3)/2)
    elif (abs(D) <= eps):
        u = -q/2.0
        u = u**(1/3) if u >= 0 else -(-(u)**(1/3))

        y1 = 2*u
        y2 = -u
        y3 = -u
    else:
        r = math.sqrt(-p*p*p/27.0)
        phi = math.acos(-q/(2*r))

        y1 = 2 * math.pow(r, 1/3) * math.cos(phi/3)
        y2 = 2 * math.pow(r, 1/3) * math.cos((phi + 2*math.pi)/3)
        y3 = 2 * math.pow(r, 1/3) * math.cos((phi + 4*math.pi)/3)
    
    x1 = y1 - A/3.0
    x2 = y2 - A/3.0 if isinstance(y2, complex) else complex(y2 - A/3.0, 0)
    x3 = y3 - A/3.0 if isinstance(y3, complex) else complex(y3 - A/3.0, 0)

    roots = [clean_complex(x1), clean_complex(x2), clean_complex(x3)]
    print_roots(set(roots))


