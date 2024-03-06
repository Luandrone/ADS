class Passaro:
    def __init__(self, vida, ataque, defesa):
        self.vida = vida
        self.ataque = ataque
        self.defesa = defesa

    def atacar(self, alvo):
        pass

    def fugir(self, destino):
        pass

class PassaroAereo(Passaro):
    def voar(self):
        pass

class PassaroAquatico(Passaro):
    def nadar(self):
        pass

class PassaroDeCompanhia(PassaroAereo):
    def __init__(self, vida, ataque, defesa, companheiro):
        self.companheiro = companheiro
        super().__init__(vida, ataque, defesa)

class Pinguim(PassaroAquatico):
    def __init__(self, vida, ataque, defesa, peso):
        self.peso = peso
        super().__init__(vida, ataque, defesa)

aguia = PassaroDeCompanhia(100, 300, 250, 'Rafael')
pinguim = Pinguim(140, 80, 400, 5)

print('chamada original')
print(1, 2, 3)
print()
print('alterando o sep')
print(1, 2, 3, sep='...')
print()
print('alterando o end')
print('prints separados', end=' ')
print('mas impressos', end=' ')
print('em uma mesma linha')


