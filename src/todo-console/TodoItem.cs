using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_console
{
    public class TodoItem
    {
        public required string Name { get; init; }

        public required int Prio { get; init; }
    }
}