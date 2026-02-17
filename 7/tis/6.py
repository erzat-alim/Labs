from math import * 

def main():
    try:
        A, B, C = [float(i) for i in input().split()]
        if (A<-1 or A>1):
            raise Exception('Incorrect A value')
        if (pi * B < 0):
            raise Exception('Incorrect B value')
        if (C % 1 == 0.5) or (tan(pi * C) == -1):
            raise Exception('Incorrect C value')
        print(acos(A) + sqrt( sin(pi*B) / (tan(pi*C))+1) )
    except Exception as ex:
        error = str(ex)
        if (error=='Incorrect A value'):
            print(f"{error} - A must be in [-1:1] range")
        if (error=='Incorrect B value'):
            print(f"{error} - B must be greater than 0")
        if (error=='Incorrect C value'):
            print(f"{error} - C must not be n+0,5 or n+0,25")

if __name__ == "__main__":
    exit(main())