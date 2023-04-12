/* Bonus: Rendere le variabili nel codice non più hardcoded
 * Farsi dire dall'utente le seguenti informazioni tramite l'input della console
 * Titolo
 * Autore
 * ISBN
 * Numero pagine
 * Peso del libro
 * Larghezza, altezza e profondità del libro
 * Valutazione media
 * Numero di recensioni
 * Se è disponibile in versione Kindle
 * Se la copertina flessibile è disponibile
 */

// Lista dei dati del libro da chiedere all'utente
Console.Write("Titolo del libro: ");
string title = Console.ReadLine();

Console.Write("Autore del libro: ");
string author = Console.ReadLine();

Console.Write("Inserire ISBN: ");
long isbn = long.Parse(Console.ReadLine());

Console.Write("Numero di pagine del libro: ");
int numberOfPages = int.Parse(Console.ReadLine());

Console.Write("Peso del libro: ");
int weight = int.Parse(Console.ReadLine());

Console.Write("Larghezza: ");
float width = float.Parse(Console.ReadLine());

Console.Write("Altezza: ");
float height = float.Parse(Console.ReadLine());

Console.Write("Profondità: ");
float depth = float.Parse(Console.ReadLine());

Console.Write("Valutazione media: ");
float averageRating = float.Parse(Console.ReadLine());

Console.Write("Numero di recensioni: ");
int numberOfReviews = int.Parse(Console.ReadLine());

Console.Write("Versione Kindle disponibile: ");
bool kindle = bool.Parse(Console.ReadLine());

Console.Write("Copertina flessibile disponibile: ");
bool flexibleCover = bool.Parse(Console.ReadLine());

Console.WriteLine();

// Stampare le informazioni in console
Console.WriteLine("-------- IL LIBRO DI OGGI: " + title + " di " + author + " ------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numberOfPages + " pagine");
Console.WriteLine("Peso del libro: " + weight + " g");
Console.WriteLine("Dimensioni del libro: " + width + " cm x " + height + " cm x " + depth + " cm");
Console.WriteLine();
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numberOfReviews + " recensioni");
Console.WriteLine("Valutazione media: " + averageRating + " stelline");
Console.WriteLine("Kindle: " + kindle);
Console.WriteLine("Copertina: " + flexibleCover);
Console.WriteLine("---------------------------------------------------------------------------");