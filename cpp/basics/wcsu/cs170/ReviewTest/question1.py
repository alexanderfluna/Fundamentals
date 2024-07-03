def main():
    
    integer = 0
    while integer <= 0:
        integer = int(input("Please enter a non-negative integer "))

    reverse = 0
    
    while integer > 0:
        remainder = integer % 10
        reverse = (reverse * 10) + remainder
        integer = integer//10

    print(f"The reverse number is {reverse}")

main()
