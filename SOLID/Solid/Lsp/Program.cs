using Lsp.Payments;

//DebitCard card = new();
//CreditCard card = new();
NubankRewards card = new();

card.Validate();
card.CollectPayment();

Console.ReadLine();