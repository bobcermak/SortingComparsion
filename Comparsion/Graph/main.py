import matplotlib.pyplot as plt

def create_your_graph(x_array: list[any], y1_array: list[any], y2_array: list[any], graph_title: str = "Porovnání řadících algoritmů", y1_title: str = "Bubble sort", y2_title: str = "Quick sort", x_title: str = "Počet dat", y_title: str = "Výsledný čas - NA == 10,000") -> None:
    plt.plot(x_array, y1_array, marker = "o", linestyle = "-", color = "b", label = y1_title)
    plt.plot(x_array, y2_array, marker = "o", linestyle = "-", color = "r", label = y2_title)
    plt.xlabel(x_title)
    plt.ylabel(y_title)
    plt.title(graph_title)
    plt.legend()
    plt.grid()
    plt.show()
#create_your_graph([10, 100, 1000, 10000, 100000], [0.00010597, 0.007002, 0.6364, 62.97, 6741], [0.00013150, 0.008637, 0.7658, 75.7, 10000], "Porovnání řadících algoritmů - náhodná data - milisekundy (ms)")
#create_your_graph([10, 100, 1000, 10000, 100000], [0.00009895, 0.006824, 0.6265, 61.75, 6305], [0.00012966, 0.008429, 0.7472, 73.93, 10000], "Porovnání řadících algoritmů - srovnaná data - milisekundy (ms)")