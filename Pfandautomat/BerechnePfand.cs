class PfandAutomat
{
    public decimal BerechnePfand(int[] array)
    {
        if (array == null || array.Length != 3)
        {
            return 0m;
        }

        decimal dosePfand = 0.25m;
        decimal glasPfand = 0.15m;
        decimal einwegPfand = 0.08m;

        int anzahlDosen = array[0];
        int anzahlGlas = array[1];
        int anzahlEinweg = array[2];

        if (anzahlDosen < 0 || anzahlGlas < 0 || anzahlEinweg < 0)
        {
            return 0m;
        }

        decimal gesamt = (anzahlDosen * dosePfand)
                       + (anzahlGlas * glasPfand)
                       + (anzahlEinweg * einwegPfand);

        return gesamt;
    }
}
