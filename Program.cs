double vlt, PM, tj, PMN, Vln, J, IOFM, IOFD, VPF, CCR;
 Console.Clear();
Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---");

Console.Write("Valor total da fatura (R$)...:");
vlt = Convert.ToDouble(Console.ReadLine()!);


Console.Write("Pagamento mínimo (%).........:");
PM = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Taxa de juros mensais (%)....:");
tj= Convert.ToDouble(Console.ReadLine()!);

PMN = vlt * PM/100;
Vln = vlt - PMN;
J =   Vln * tj / 100;
IOFM = Vln * 0.0038;
IOFD = Vln * 0.00246;
VPF = Vln + J + IOFM + IOFD;
CCR = J + IOFM + IOFD;
Console.WriteLine("\n");
Console.WriteLine(@$"Pagamento mínimo..................: {PMN:n2}");
Console.WriteLine("\n");
Console.WriteLine("Caso seja pago o valor mínimo:");
Console.WriteLine("\n");
Console.WriteLine(@$"Valor não pago....................: {Vln:n2}
Juros.............................: {J:n2}
IOF mensal........................:{ IOFM:n2}
IOF diário........................: {IOFD:n2}

Valor a pagar na próxima fatura...: {VPF:n2}
Custo do crédito rotativo.........: {CCR:n2}");