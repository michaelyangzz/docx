# Day 1: Input, Variables, and Type Conversion
# AI Agents live on data. This script practices taking input (data) 
# and processing it (logic).

def calculate_year_100():
    # 1. Ask the user for input
    # NOTE: input() always returns a string (text), even if you type a number!
    name = input("What is your name? ")
    current_age = input("How old are you? ")

    # 2. Process the Data
    # We must convert the string "25" into the integer 25 to do math.
    # This is called "Type Casting".
    age_int = int(current_age)
    
    # Calculate the year they turn 100
    # We assume the current year is 2025 (you can use a library for this later)
    current_year = 2025
    years_left = 100 - age_int
    turn_100_year = current_year + years_left

    # 3. Output the Result
    # f-strings (f"...") are the standard way to insert variables into text in Python
    print(f"Hello, {name}!")
    print(f"You will turn 100 years old in the year {turn_100_year}.")

# This block tells Python to run the function if this file is executed directly
if __name__ == "__main__":
    calculate_year_100()