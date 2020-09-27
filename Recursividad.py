def sumaRecursividad(n):
    if n == 1:
        return 1
    else:
        return n + sumaRecursividad(n-1)

num = int(input("ingrese numero: "))
print("la suma es: ", + sumaRecursividad(num))