# This program will ask the user for the length, width, and depth of their swimming pool.
# Then, it will calculate the perimeter, area, and volume of the pool.
# By: Alexander Luna

def main():
    l = eval(input("What is the length of your swimming pool in feet? "))
    w = eval(input("What is the width of your swimming pool in feet? "))
    d = eval(input("What is the depth of your swimming pool in feet? "))
    print(f"The perimeter of your pool is {(l*2)+(w*2)} ft")
    print(f"The area of your pool is {l*w} sq. ft")
    print(f"The volume of your pool is {l*w*d} cu. ft")
    
main()
