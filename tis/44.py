import datetime

def current_year():
    return datetime.datetime.now().year

def main():
    try:
        user_input = input("Enter the year of birth: ").strip()
        
        if not user_input.lstrip('-').isdigit():
            raise Exception("bad_input")
        
        y = int(user_input)
        year_now = current_year()
        
        if y < 0:
            raise Exception("negative_year")
        if y > year_now:
            raise Exception("future_year")
        
        age = year_now - y
        print(f"Your age: {age}")
        return 0
        
    except Exception as e:
        error_type = str(e)
        
        if error_type == "negative_year":
            print("Error: the year of birth cannot be less than 0.")
        elif error_type == "future_year":
            print("Error: the year of birth cannot be greater than the current year.")
        elif error_type == "bad_input":
            print("Input error.")
        else:
            print("Unknown error.")
        return 1

if __name__ == "__main__":
    exit(main())