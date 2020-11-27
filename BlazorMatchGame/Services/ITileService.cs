using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMatchGame.Services
{
    public interface ITileService
    {
        event Action ListChange;
        List<int> OpenTiles { get; set; }
        void DoOpenTiles(int[] tiles);
        void NotifyListeners();
    }
}
