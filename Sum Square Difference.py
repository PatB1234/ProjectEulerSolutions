sumSquareNaturalNum = 0
squareSumNaturalNum = 0
temp = 0

for i in range(1, 101):

    sumSquareNaturalNum += i * i

for j in range(1, 101):

    temp += j

squareSumNaturalNum += temp * temp

print(squareSumNaturalNum - sumSquareNaturalNum)