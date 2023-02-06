RenderHeader();
var command = RenderMenu();

void RenderHeader() => 
    Console.WriteLine(
        $"|#############################################|{Environment.NewLine}" + 
        $"|               To-Do App                     |{Environment.NewLine}" +
        $"|#############################################|");

int RenderMenu()
{
    Console.Write(
        $"Wählen Sie zwischen verschiedenen Aktionen:{Environment.NewLine}" +
        $"  (1) Eintrag erstellen.{Environment.NewLine}" +
        $"  (2) Eintrag löschen.{Environment.NewLine}" +
        $"  (3) Eintrag ändern.{Environment.NewLine}" +
        $"  (4) Alle Einträge löschen.{Environment.NewLine}" +
        $"  (5) Sortieren.{Environment.NewLine}" +
        $"  (6) Alle Einträge anzeigen.{Environment.NewLine}" +
        $"  (7) Liste speichern.{Environment.NewLine}" +
        $"  (8) Ende.{Environment.NewLine}" +
        $"Auswahl:");
    return int.Parse(Console.ReadLine());
}