from contas_bancarias import ContaPoupança, ContaInvestimento

# Criação das contas
conta_poupança = ContaPoupança('001', 'Rafael')
conta_investimento = ContaInvestimento('001', 'Rafael', 'Ana')

print('\n----Operações na conta poupança----')
conta_poupança.depositar(1000)
saque_1 = conta_poupança.sacar(100)
saque_2 = conta_poupança.sacar(3000)

print(f'Primeiro saque da poupança: R$ {saque_1}')
print(f'Segundo saque da poupança: R$ {saque_2}')

print(f'\n----Operações na conta investimento----')
conta_investimento.depositar(500)
saque_3 = conta_investimento.sacar(300)
saque_4 = conta_investimento.sacar(300)

print(f'Primeiro saque da conta investimento: R$ {saque_3}')
print(f'Segundo saque da conta investimento: R$ {saque_4}')
