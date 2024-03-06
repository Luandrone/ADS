# notas = {'Jack': 6.0, 'Anna': 9.0, 'Megan': 8.0}

# pessoa = {
#     'nome': 'Rafael',
#     'cor favorita': 'azul',
#     'idade': 34,
#     'telefone': '(11) 9999-9999',
#     'email': '123@gmail.com'
# }

# def jogo21():
#     soma = 0
#     while soma < 21:
#         carta = int(input('Digite o valor da carta: '))
#         soma += carta

#         if soma < 21:
#             continuar = input('Deseja continuar, digite 1 para sim, 2 para não: ')
#             if continuar == 1:
#                 break
#             else:
#                 print(f'Você desistiu do jogo, seu número foi {soma}')
#                 break
#         elif soma == 21:
#             print('Você chegou ao 21')
#         else:
#             print(f'Você passou do 21, seu número foi {soma}')        
        
# jogo21()

# lista = ['a', 1, True, 3.5]

# for valor in lista:
#     print(f'valor: {valor}, do tipo: {type(valor)}')
    
# print('-----\nfim')

lista = ['a', 1, True, 3.5]
for i in range(len(lista)):
    print(i, lista[i])