x = 0
y = 0

def init(a, b):
    global x
    global y
    x = a
    y = b
def sum():
    return x + y

sum(init(11, 22))