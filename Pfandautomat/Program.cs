var automat = new PfandAutomat();
decimal betrag = automat.BerechnePfand(new int[] { 5, 2, 3 });
Console.WriteLine($"Pfandbetrag: {betrag} €");
