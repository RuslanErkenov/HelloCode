# На вход программе подаются два целых числа aa и bb. Напишите программу, которая выводит:

# сумму чисел aa и bb;
# разность чисел aa и bb;
# произведение чисел aa и bb;
# частное чисел aa и bb;
# целую часть от деления числа aa на bb;
# остаток от деления числа aa на bb;
# корень квадратный из суммы их 1010-х степеней: \sqrt{a^{10} + b^{10}} 
# a 
# 10
#  +b 8
# 10.

aa = int(input('Enter 1st number: '))
bb = int(input('Enter 2nd number: '))
print (aa+bb)
print (aa-bb)
print (aa*bb)
print (aa//bb)
print (aa%bb)
print (int(((aa**10)+(bb**10))**0.5))