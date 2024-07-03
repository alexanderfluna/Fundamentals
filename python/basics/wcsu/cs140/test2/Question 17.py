# Test 2 | Question 17
#   This program will ask the user for the three distances of a triangle. Then it will check if the three distances can form a triangle. Then it will calculate the perimeter of the triangle.
#   Then it will calculate the area of the triangle. Then it will ask the user for the height. Then it will calculate the volume of the pyramid.
# Alexander Luna | 12/4/2020 | Student Code: 50242833

# Main function
def main():
    # Prints purpose of the program
    print("This program will ask the user for the three distances of a triangle. Then it will check if the three distances can form a triangle. Then it will calculate the perimeter of the triangle.")
    print("Then it will calculate the area of the triangle. Then it will ask the user for the height. Then it will calculate the volume of the pyramid.", end='\n\n')

    # Calls getDistances
    a, b, c = getDistances()

    # Calls calculatePerimeter
    trianglePerimeter = calculatePerimeter(a,b,c)

    # Calls calculateArea
    triangleArea = calculateArea(trianglePerimeter,a,b,c)

    # Calls calculateVolume
    pyramidVolume = calculateVolume(triangleArea)

    # Prints calculations of triangle
    print(f"The sides of the traingle are {a}, {b}, and {c}. The triangle's perimeter is: {trianglePerimeter}. The triangle's area is: {triangleArea}. The volume of the pyramid is: {pyramidVolume}.")

# Asks user for distances
def getDistances():

    # Infinite loop
    while True:
        # Tries code below
        try:
            
            # Initializes variables
            a, b, c = 0, 0, 0

            # Prompts user
            while a <= 0:
                a = float(input("What's the smallest side of the triangle? "))

            while b <= 0:
                b = float(input("What's the second smallest side of the triangle? "))

            while c <= 0:
                c = float(input("What's the largest side of the triangle? "))

            # Returns if distances can form a triangle
            if (a+b)>c and (a+c)>b and (b+c)>a:
                return a, b, c
            # Starts while loop over if they cannot
            else:
                print("These distances cannot form a triangle. Try again.")
                continue
        
        # Exits for this error
        except KeyboardInterrupt:
            exit()
        # Error message for incorrect input
        except:
            print("You must type a decimal number for the sides of the triangles. Try again.")

# Calculates perimeter
def calculatePerimeter(a,b,c):
    return a+b+c

# Calculates area
def calculateArea(trianglePerimeter,a,b,c):
    hp = trianglePerimeter/2
    return (hp*(hp-a)*(hp-b)*(hp-c))**(1/2)

# Calculates volume
def calculateVolume(triangleArea):
     # Infinite loop
    while True:
        # Tries code below
        try:
            # Initializes variable
            height = 0

            # Prompts user
            while height <= 0:
                height = float(input("What is the height? "))

            # Formula for volume
            volume = triangleArea*height/3
            return volume
        
        # Exits for this error
        except KeyboardInterrupt:
            exit()
        # Error message for incorrect input and terminates program
        except:
            print("You must type a decimal number for the height")
            exit()

main()
