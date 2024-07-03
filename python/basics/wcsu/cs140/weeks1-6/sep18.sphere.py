import math

def main():
    print("This program will calculate the volume and surface area of a sphere.\n")
    r = float(input("What is the radius of the sphere in meters? "))
    print(f"The volume of the sphere is {(4/3)*math.pi*(r*r*r)} cube meters")
    print(f"The surface area of the sphere is {4*math.pi*(r*r)} square meters")

main()
