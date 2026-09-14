using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGUI
{
    public interface IDataStorage
    {
        void SaveGame<T>(List<T> data) where T : ISaveable;
        List<T> LoadGame<T>() where T : ISaveable;
    }
}
