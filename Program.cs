namespace Promillerechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Der User soll angeben können, wieviel Bier in Litern getrunken wurde.
            //Daraus wird die Menge des Reinalkohols in Gramm berechnet.
            //Getrunkene Menge in Milliliter * Alkoholgehalt * Dichte des Ethanols.
            //Bei Bier also: Getrunkene Menge in Milliliter * 0.05 * 0.8
            //Der User soll auch sein Gewicht in Kilogramm angeben.
            //Dann wird der Blutalkoholgehalt in Promille berechnet.
            //c = A / (0.65*G)
            //c ist der Promillewert, A der aufgenommene ALkohol in Gramm und G das Körpergwicht in kg.
            //Es soll dann eine Ausgabe, abhängig vom Promillewert folgen:
            //bis 0.3: "Noch akzeptabel. Dennoch vorsichtig sein!"
            //bis 0.5: "Achtung! Hände weg vom Steuer."
            //bis 0.8: "Das ist jetzt schon ganz schön ordentlich."
            //ab 0.8: "Kein Kommentar..."
            //Wähle die passenden Datentypen für jeweils notwendigen Variablen.
            //Etwaige Eingabefehler sollen über einen else-Block abgefangen werde.

            Console.WriteLine("ACHTUNG: Polizei hier. Kurze Frage: Wie viel Bier, in Litern, hast du getrunken? (nur Ziffern verwenden)");
            double bierLitern = Convert.ToDouble(Console.ReadLine());
            double bierMili = bierLitern * 1000;
            double reinAlkohol = bierMili * 0.05 * 0.8;

            Console.WriteLine("Gib mal auch dein Gewicht in Kg. -.-° (auch nur Ziffern verwenden)");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            double blutalkoholgehalt = reinAlkohol / (0.65 * gewicht);

            Console.WriteLine($"Dein Blutalkoholgehalt lautet {blutalkoholgehalt} Promille.");

            if (blutalkoholgehalt < 0.3)
            {
                Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");
            }
            else if (blutalkoholgehalt < 0.5)
            {
                Console.WriteLine("Achtung! Hände weg vom Steuer.");
            }
            else if (blutalkoholgehalt < 0.8)
            {
                Console.WriteLine("Das ist jetzt schon ganz schön ordentlich.");
            }
            else if (blutalkoholgehalt >= 0.8)
            {
                Console.WriteLine("Kein Kommentar...");
            }
            else
            {
                Console.WriteLine("Hmm... wusstest du nicht, dass man die Polizei nicht anlügen darf? :o");
            }
        }
    }
}