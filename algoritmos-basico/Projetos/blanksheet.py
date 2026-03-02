number = int(input())

counter = 0
for i in range(1, number+1):
    if 7 % i == 0:
        counter += 1
    else:
        continue

if counter == 2:
    print("Primo!")
