/*
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). L’array deve essere già inizializzato nel programma ordinato già con i cibi dal più preferito al meno preferito, e i vostri cibi preferiti non vanno chiesti all’utente tramite input (hard-coded).
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:

- La lunghezza della classifica
- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
- Il vostro cibo top (prima posizione della classifica)
- Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

Cercate per ogni richiesta che viene fatta di preparare le rispettive funzioni  e di usarle nel vostro programma principale!
*/



string[] cibiPreferiti = { "Pizza", "Pasta", "Lasagna", "Bistecca", "Pesce" };


Console.WriteLine("Lunghezza array: " + cibiPreferiti.Length);
Console.WriteLine("");
classificaCibiPreferiti(cibiPreferiti);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Cibo preferito: " + cibiPreferiti[0]);
Console.WriteLine("Cibo sfavorito: " + cibiPreferiti[4]);

void classificaCibiPreferiti(string[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine((i + 1) + ") " + array[i]);
    }

}

