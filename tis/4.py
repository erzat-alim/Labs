import random

random_floats = [round(random.uniform(1, 100), 3) for i in range(4)]
for i in range(len(random_floats)):
    for j in range(len(random_floats)):
        if random_floats[i] < random_floats[j]:
            random_floats[i], random_floats[j] = random_floats[j], random_floats[i]
        print(random_floats, i, j)

print(random_floats)