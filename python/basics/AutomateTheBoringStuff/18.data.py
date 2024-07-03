print("LESSON 18: DATA STRUCTURES", end ='\n\n')

# Cat dictionary
cat = {'name': 'Zophie', 'age': 7, 'color': 'gray'}

# allCats list
allCats = []

# Adds dictionaries to list
allCats.append({'name': 'Zophie', 'age': 7, 'color': 'gray'})
allCats.append({'name': 'Pooka', 'age': 5, 'color': 'black'})
allCats.append({'name': 'Fat-tail', 'age': 5, 'color': 'gray'})
allCats.append({'name': '???', 'age': -1, 'color': 'orange'})

# Prints entire list
print(allCats)

print("___________________________________________________________________________")


print("Tic-Tac Toe:", end ='\n\n')


theBoard = {'top-L': 'O', 'top-M': 'O', 'top-R': 'O',
            'mid-L': 'X', 'mid-M': 'X', 'mid-R': ' ',
            'low-L': ' ', 'low-M': ' ', 'low-R': 'X',}
print(theBoard)

def printBoard(board):
    print(board['top-L'] + '|' + board['top-M'] + '|' + board['top-R'])
    print('-----')
    print(board['mid-L'] + '|' + board['mid-M'] + '|' + board['mid-R'])
    print('-----')
    print(board['low-L'] + '|' + board['low-M'] + '|' + board['low-R'])

printBoard(theBoard)

print("___________________________________________________________________________")

print("type() Function:", end ='\n\n')

print(type(42))
print(type('hello'))
print(type(3.14))
print(type(theBoard))
print(type(theBoard['top-R']))
