using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSystem.Shared.Model
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
