using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleLogic
{
    public class GameTurn
    {
        public bool IsMyTurn { get; set; }
        public WinState WinnerState { get; set; }
        public byte[] FieldUser { get; set; }
    }
}
