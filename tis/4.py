import random
import psutil
import os

process = psutil.Process(os.getpid())
mem_mb = process.memory_info().rss / 1024.0 / 1024.0
print(f"Memory usage: {mem_mb:.2f} MB")

random_floats = [round(random.uniform(1, 100), 3) for i in range(20)]
print(random_floats)
for i in range(len(random_floats)):
    for j in range(len(random_floats)):
        if random_floats[i] < random_floats[j]:
            random_floats[i], random_floats[j] = random_floats[j], random_floats[i]
print(random_floats)