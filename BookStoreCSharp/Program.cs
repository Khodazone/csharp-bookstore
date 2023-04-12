/* Esercizio: inserire in hardcoded le seguenti informazioni che troviamo su Amazon del libro Clean Code:
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

// Lista dei dati del libro
string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string author = "Robert C. Martin";
long isbn = 9780132350884;
int numberOfPages = 431;
int weight = 800;
float width = 17.78f;
float height = 2.79f;
float depth = 23.37f;
float averageRating = 4.7f;
int numberOfReviews = 5414;
bool kindle = true;
bool flexibleCover = true;

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
Console.WriteLine("Kindle disponibile: " + kindle);
Console.WriteLine("Copertina flessibile: " + flexibleCover);
Console.WriteLine("---------------------------------------------------------------------------");