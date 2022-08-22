using BancoCSharp.Entities;
using BancoCSharp.Entities.Enums;

Console.WriteLine("**********************************");
Console.WriteLine("*********** Banco C# *************");
Console.WriteLine("**********************************");
Console.WriteLine("");


Endereco endereco = new Endereco
{
    CEP = "123123123",
    Rua = "Rua 123",
    Numero = 53
};

Titular titular01 = new Titular("José da Silva", "12345678901", "21999999999", endereco);
Titular titular02 = new Titular("Maria da Silva", "12995678901", "21998987999", endereco);
Titular titular03 = new Titular("Ana", "12989378901", "21998123499", endereco);



ContaCorrente conta03 = new ContaCorrente(titular01, 100.00);

try{
    conta03.Depositar(400.00);
    conta03.Sacar(400.00);
    conta03.Sacar(100.00);

    //conta03.Sacar(37.00);


    conta03.ImprimirExtrato();
}
catch(Exception ex){
    Console.WriteLine(ex.Message);
}

