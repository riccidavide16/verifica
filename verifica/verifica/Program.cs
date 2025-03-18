//esercizio A
void popolaVendite(int[,]v)
{ 
    int pluto;
   for(int i = 0; i < v.GetLength(0); i++)
    {

        for (int j = 0; j < v.GetLength(1); j++)
        { 
            if(j == 2)
            {
                v[j,i ] = 0;

            }
            if (j == 1)
            {
                Random random = new Random();
                pluto = random.Next(100, 1000);
                v[i, j] = pluto;
            }
        }
    }
}
//esercizio B
void cumulativa(int[,]v)
{
    int somma = 0;
    for(int i = 0; i < v.GetLength(0); i++)
    {

        for(int j=0;i< v.GetLength(1); j++)
        {
            if (i != 0)
            {
                somma+= v[i-1,j];
                Console.WriteLine(somma);
            }

        }
    }
}
//esercizio D
void verifica(string frase) {
   
    for(int i = 0; i < frase.Length; i++)
    {
        for(int j=0;j< frase.Length; j++)
        {

        }   
    }
}
//esercizio C
void genera(string frase) {
    frase=frase.ToLower();
    for (int i = 0; i < frase.Length; i++)
    {
       
    }
}
