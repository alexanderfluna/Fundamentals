def main():
    rows = int(input("How many rows? "))
    
    for i in range(rows, 0, -1):
        k = 1
        for j in range(1, i + 1):
            print(k, end=' ')
            k += 1
        print()  
            
        
main()
