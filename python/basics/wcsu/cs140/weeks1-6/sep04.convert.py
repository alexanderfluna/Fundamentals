# This program converts centimeters into inches.
# It also converts Celsius to Fahrenheit in the range from 0C to 25C in a table

def main():
    print("This program converts centimeters into inches.")
    print("It also converts Celsius to Fahrenheit in the range from 0C to 25C in a table.")
    print("\n")
    cm()
    celsius()

def cm():
    for i in range(5):
        cm = eval(input("Please enter the length in cm: "))
        inches = cm/2.54
        print(f"The length in inches is {inches}")

def celsius():
    for i in range(26):
        fahrenheit = (i * 9/5) + 32
        print("______________")
        print(f"|{i}°C | {fahrenheit}°F|")
    print("______________")

main()
