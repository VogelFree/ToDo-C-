namespace todo_console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ConsoleUI
    {
        public required List<TodoItem> Todos { get; init; }

        public void Render()        
        {
            switch (this.RenderMenu())
            {
                case 1: this.RenderNewEntry(); break;
                case 2: this.RenderDeleteEntry(); break;
                case 3: this.RenderEditEntry(); break;
                case 4: this.RenderDeleteAllEntries(); break;
                case 5: this.RenderSortEntries(); break;
                case 6: this.RenderAllEntries(); break;
                case 7: this.RenderSaveEntries(); break;
                default: System.Environment.Exit(0); break;
            };
            Render();
        }

        private void RenderNewEntry() {
            this.RenderHeader();
            Console.WriteLine("  Bitte gebe folgende Daten ein:");
            Console.Write("  Name: ");
            var name = Console.ReadLine();
            Console.Write("  Prio: ");
            var prio = int.Parse(Console.ReadLine());
            this.Todos.Add(new TodoItem
            {
                Name = name,
                Prio = prio,
            });
        }

        private void RenderDeleteEntry(){
            this.RenderAllEntries();
            Console.WriteLine(
                $"|############################################|");
            Console.Write("  Welcher Eintrag soll gelöscht werden?: ");
            var index = int.Parse(Console.ReadLine());
            if (index < this.Todos.Count) 
            {
                this.Todos.RemoveAt(index);
                Console.Write($"Todo an Position '{index}' ist gelöscht!");
            }
            else
            {
                Console.Write($"Es gibt kein Todo mit der Nummer {index}");
            }

            Console.ReadLine();
        }

        private void RenderEditEntry(){

        }

        private void RenderDeleteAllEntries() => this.Todos.RemoveAll(item => true);

        private void RenderSortEntries(){

        }

        private void RenderAllEntries()
        {
            this.RenderHeader();
            Console.WriteLine(
                $"| Index | Name                        | Prio  |");
            this.Todos.ForEach(RenderEntry);
            Console.ReadLine();
        }

        private void RenderSaveEntries(){

        }

        private int RenderMenu()
        {
            this.RenderHeader();
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

        private void RenderHeader()
        {
            Console.Clear();
            Console.WriteLine(
                $"|#############################################|{Environment.NewLine}" + 
                $"|               To-Do App                     |{Environment.NewLine}" +
                $"|#############################################|");
        }

        private void RenderEntry(TodoItem item) =>
            Console.WriteLine(
                $"|   {this.Todos.FindIndex(i => i.Equals(item))}   | { item.Name }           | { item.Prio } |");
    }
}