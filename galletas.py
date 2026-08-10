class Galleta:
    def __init__(self, sabor):
        self.sabor = sabor

    def sabor_galleta(self):
        return f"Galleta de {self.sabor}"

g1= Galleta("Chocolate")
print(g1.sabor_galleta())
