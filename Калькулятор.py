# Python мне привычнее, поэтому решил продублировать код на нём.

a_1: float = 1
a_2: float = 2
b_1: float = 3
b_2: float = 4

def calculate(c_1: float, c_2: float) -> tuple[float, float]:
    d: float = a_1 * b_2 - a_2 * b_1

    x: float = (c_1 * b_2 - c_2 * b_1) / d
    y: float = (a_1 * c_2 - a_2 * c_1) / d

    return (x, y)

def convert(raw_number: str) -> float|None:
    try:
        number: float = float(raw_number)

    except ValueError:
        print(f"'{raw_number}' это не число.")
        return None

    return number

def main():
    raw_c_1: str = input("Введите первое число: ")
    c_1: float = convert(raw_c_1)

    if c_1 == None:
        return

    raw_c_2: str = input("Введите второе число: ")
    c_2: float = convert(raw_c_2)

    if c_2 == None:
        return

    x, y = calculate(c_1, c_2)

    print(f"Результат при заранее заданных числах {a_1}, {a_2}, {b_1}, {b_2}:\n\n" + f"x = {x};\ny = {y};")

if __name__ == "__main__":
    main()