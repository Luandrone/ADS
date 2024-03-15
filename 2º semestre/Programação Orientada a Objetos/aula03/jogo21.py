def jogo21():
    soma = 0
    while soma < 21:
        carta = int(input('Digite o valor da carta: '))
        soma += carta

        if soma < 21:
            continuar = input('Deseja continuar, digite 1 para sim, 2 para não: ')
            if continuar == 1:
                break
            else:
                print(f'Você desistiu do jogo, seu número foi {soma}')
                break
        elif soma == 21:
            print('Você chegou ao 21')
        else:
            print(f'Você passou do 21, seu número foi {soma}')        
        
jogo21()