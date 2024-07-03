spam = 0
while spam < 5:
    print("Hi")
    spam = spam + 1

# break will exit the loop
name = ''
while True:
    print('Please type your name.')
    name = input()
    if name == 'your name':
        break
print("Thank you!")

# continue will skip over the rest of the lines in the loop
ham = 0
while ham < 5:
    ham = ham + 1
    if ham == 3:
        continue
    print('ham is ' + str(ham))
