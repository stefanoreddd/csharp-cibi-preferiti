/*
BONUS
- Chiedere all'utente quanti cibi preferiti ha, e farglieli inserite da input della Console nell'array.
- Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Potrebbe essere interessante creare una funzione chiamata indiciMedianaArray(int lunghezzaArray) che vi restituisce l'indice della posizione mediana (che restituisca gli indici delle eventuali posizioni mediani) e poi fare una funzione (StampaArrayMediana) che si occupa di fare tutto il lavoro con  la funzione precedente e richiedendo direttamente l'intero array. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 
*/


using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Quanti cibi preferiti hai?");
string numeroCibiUser = Console.ReadLine();
int numeroCibi = int.Parse(numeroCibiUser);

string[] cibiPreferiti = new string[numeroCibi];

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine("Inserisci il " + (i + 1) + "° cibo:");
    string ciboPreferito = Console.ReadLine();
    cibiPreferiti[i] = ciboPreferito;
}

classificaCibiPreferiti(cibiPreferiti);
posizioneMediana(cibiPreferiti);









// FUNZIONI

void classificaCibiPreferiti(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine((i + 1) + ") " + array[i]);
    }

}



void posizioneMediana(string[] array)
{
    Console.WriteLine("");
    Console.WriteLine("Cibo preferito: " + array[0]);
    Console.WriteLine("Cibo sfavorito: " + array[array.Length - 1]);

    
    if (array.Length % 2 == 0)
    {
        Console.WriteLine("Posizione mediana: " + array[(array.Length / 2) - 1] + ", " + array[array.Length / 2]);
    }
    else
    {
        Console.WriteLine("Posizione mediana: " + array[array.Length / 2]);
    }

       
}