class Teste:
    def __init__(self):
        self.__nome = 0
        self.cont = 0

    @property
    def nome(self):
        self.cont += 1
        print(f'Executando a property...{self.cont}')
        return self.__nome
    
    @nome.setter
    def nome(self, novo_nome):
        print('Executando o setter...')
        self.__nome = novo_nome