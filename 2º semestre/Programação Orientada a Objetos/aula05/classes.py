class Livro:
    def __init__(self, nome, autor):
        self.nome = nome
        self.autor = autor
        self.editora = 'Nome da editora'

    def identidade(self):
        return (f'Sou o livro {self.nome}, e estou salvo'
                f'no endereço de memória: {id(self)}')

livro_1 = Livro('O Senhor dos Anéis', 'J. R. R. Tolkien')
livro_2 = Livro('O Processo', 'Franz Kafka')

print('livro 1:', vars(livro_1))
print(livro_1.nome)
print(livro_1.autor)
print('livro 2:', vars(livro_2))