name = "Alice"
if name == "Alice":
    print("Hi Alice")
print("\n")


password = "swordfish"
if password == "swordfish":
    print("Access granted.")
else:
    print("Wrong password.")
print("\n")

name = "Bob"
age = 3000
if name == "Alice":
    print("Hi Alice")
elif age < 12:
    print("You are not Alice, kiddo")
elif age > 2000:
    print("Unlike you, Alice is not an undead, immortal vampire")
elif age > 100:
    print("You are not alice, grannie.")
print("\n")

# This works because conditions can use truthy and falsey values
# Having a name would enter True. A blank string would enter False.
print("Enter a name.")
name = input()
if name:
    print("Thank you for entering a name.")
else:
    print("You did not enter a name.")

# bool(0) == False
# bool(42) == True
# bool('Hello') == True
# bool(' ') == False
