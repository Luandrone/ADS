class Mae:
    def _init_(self):
        print('executando o init de Mãe')

class Filha(Mae):
    def _init_(self):
        print('executando o init de Filha')

class Neta(Filha):
    def _init_(self):
        print('executando o init de Neta')