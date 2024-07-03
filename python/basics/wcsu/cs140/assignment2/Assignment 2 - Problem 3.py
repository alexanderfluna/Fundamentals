# Assignment #2 | Problem 3
#   This program will ask the user for the coordinates of the center and a point on a circle.
#   Then, it will calculate the radius, circumference, and area of the circle.
# Alexander Luna | November 20, 2020

# Main function that calls all the other functions
def main():

    # Calls getCoordinates
    x1Center, y1Center, x2Point, y2Point = getCoordinates()

    # Calls calculateRadius
    circleRadius = calculateRadius(x1Center, y1Center, x2Point, y2Point)
    print("The radius of the circle is: {0:0.5f}.".format(circleRadius))

    # Calls calculateDiameter
    circleDiameter = calculateDiameter(circleRadius)
    print("The diameter of the circle is: {0:0.5f}.".format(circleDiameter))

    # Calls calculateCircumference
    circleCircumference = calculateCircumference(circleRadius)
    print("The circumference of the circle is: {0:0.5f}.".format(circleCircumference))

    # Calls calculateArea
    circleArea = calculateArea(circleRadius)
    print("The area of the circle is: {0:0.5f}.".format(circleArea))


# Asks the user for the coordinates of the center and a point on a circle
def getCoordinates():
    
    # Infinite loop
    while True:

        # Tries code below first
        try:

            # Gets coordinates
            x1Center = float(input("Enter the x coordinate of the center of the circle: "))
            y1Center = float(input("Enter the y coordinate of the center of the circle: "))
            x2Point = float(input("Enter the x coordinate of a point on the circle: "))
            y2Point = float(input("Enter the y coordinate of a point on the circle: "))
            
            # Returns variable when positive integer is entered
            return x1Center, y1Center, x2Point, y2Point

        # Exits the program for the error KeyboardInterrupt
        except KeyboardInterrupt:
            exit()
        # Restarts while loop
        except:
            continue

# Calculates the distance of two points
def calculateDistance(x1Center, y1Center, x2Point, y2Point):
    
    # Formula for distance
    distance = ((x2Point-x1Center)**2 + (y2Point-y1Center)**2)**(1/2)
    return distance

# Calculates the radius of a circle
def calculateRadius(x1Center, y1Center, x2Point, y2Point):
    
    # Calls distance function
    radius = calculateDistance(x1Center, y1Center, x2Point, y2Point)
    return radius

# Calculates the diameter of a circle
def calculateDiameter(circleRadius):
    return circleRadius * 2

# Calculates the circumference of a circle
def calculateCircumference(circleRadius):
    
    # Formula for circumference
    pi = 3.14159
    circumference = 2 * pi * circleRadius
    return circumference

# Calculates the area of a circle
def calculateArea(circleRadius):
    
    # Formula for area
    pi = 3.14159
    area = pi * circleRadius ** 2
    return area

main()
