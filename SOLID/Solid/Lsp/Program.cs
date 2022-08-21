using Lsp.Payments;

DebitCard card = new();
//CreditCard card = new();

card.Validate();
card.CollectPayment();

Console.ReadLine();