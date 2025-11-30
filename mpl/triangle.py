def triangleIneq(a, b, c):
    result = "not possible"
    if abs(b - c) < a < b + c and abs(a - c) < b < a + c and abs(a - b) < c < a + b:
        result = "possible"        
    else:
        result = "not possible"

    return result


print(triangleIneq(3,3,10))