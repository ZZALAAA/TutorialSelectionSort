Console.WriteLine("SELECTION SORT");

int[] array = { 8, 7, 9, 2, 3, 1, 5, 4, 6 };

SelectionSort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);                //questo ciclo fa stampare in output i numeri contenuti nel vettore (array)                                         
}

int SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)                  
                                                                //ogni volta che il ciclo viene usato l'algoritmo cerca il numero minimo e lo scambia nella parte non ordinata
                                                                //del vettore e lo scambia con l'elemento nella posizione corretta
                                                                //Questo processo viene ripetuto fino a quando l'intero array non viene ordinato in ordine crescente.
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[min] > array[j])
            {
                min = j;
            }
        }

        int temp = array[i];             //Per ogni elemento dell'array(i): Si assume che l'elemento corrente sia il più piccolo (viene memorizzato nell'indice min).
        array[i] = array[min];          //Se trova un elemento più piccolo, aggiorna l'indice min con la posizione di questo nuovo elemento più piccolo.                                    
        array[min] = temp;             //Alla fine del ciclo interno (j), l'elemento più piccolo trovato viene scambiato con l'elemento all'indice i
                                       //L'array si ordina gradualmente, mettendo ogni elemento più piccolo in ordine, fino a completare l'ordinamento.
    }

    return array[1];
}
Console.ReadLine();
