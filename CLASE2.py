class Persona:
    def __init__(self, nombre , edad):
        self.nombre = nombre
        self.edad = edad

    def saludar(self):
        return f"Hola, soy {self.nombre}"
    def cumplir_anios(self):
            return f"Tengo {self.edad} años"

p = Persona("Sebastian", 18)
print(p.saludar())
print(p.cumplir_anios())
