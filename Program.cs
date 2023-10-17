using Hospedagem.Model;

//Cadastro dos hospedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa pessoa = new Pessoa("João","Silva");
Pessoa pessoa2 = new Pessoa("Pedro","Silva");

hospedes.Add(pessoa);
hospedes.Add(pessoa2);

//Cria suíte
Suite suite = new Suite("Pemium",1,100);


//Cria a reserva passando a suíte e hóspedes
Reserva reserva = new Reserva(diasReservados:11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibi a quantidade de hóspedes e o valor da diária 
Console.WriteLine($"Hóspedes: {reserva.ObeterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CacularValorDiaria()}");



