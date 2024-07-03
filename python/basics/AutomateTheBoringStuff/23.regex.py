import re

phoneNumRegex = re.compile(r'\d\d\d-\d\d\d-\d\d\d\d')

mo = phoneNumRegex.search("My phone number is 415-555-1011. Your phone number is 203-456-7890.")

print("\nMy phone number is 415-555-1011. Your phone number is 203-456-7890.")
print(mo.group())

mo2 = phoneNumRegex.findall("My phone number is 415-555-1011. Your phone number is 203-456-7890.")

print("\nMy phone number is 415-555-1011. Your phone number is 203-456-7890.")
for element in range(len(mo2)):
    print(mo2[element])

print("\nMy phone number is 415-555-1011. Your phone number is 203-456-7890.")
print(phoneNumRegex.findall("My phone number is 415-555-1011. Your phone number is 203-456-7890."))