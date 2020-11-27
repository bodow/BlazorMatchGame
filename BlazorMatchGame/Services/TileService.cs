using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMatchGame.Services
{
    public class TileService : ITileService
    {
        public List<int> OpenTiles { get; set; } = new List<int>();

        public event Action ListChange;

        public void DoOpenTiles(int[] tiles)
        {
            foreach (int tileNo in tiles)
            {
                if (!OpenTiles.Contains(tileNo))
                {
                    OpenTiles.Add(tileNo);
                }
            }
            NotifyListeners();
        }
        public void NotifyListeners()
        {
            ListChange.Invoke();
        }
    }
}
