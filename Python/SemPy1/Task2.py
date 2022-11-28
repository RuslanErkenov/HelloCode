# Напишите программу для проверки истинности утверждения 
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

count = 0
for x in range(2):
    for y in range(2):
        for z in range(2):
            rez = (not(x or y or z) == ((not x) and (not y) and (not z)))
            if rez: count +=1
            else: print("Утверждение не верно")
if count == 8: print("Утверждение верно")