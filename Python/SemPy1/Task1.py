# Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
# и проверяет, является ли этот день выходным.

# Пример:

# - 6 -> да
# - 7 -> да
# - 1 -> нет

day = int(input())
A = [1, 2, 3, 4, 5]
if day == 6 or day == 7:
    print('да')
elif day in A:
    print('нет')
else:
    print('ошибка')