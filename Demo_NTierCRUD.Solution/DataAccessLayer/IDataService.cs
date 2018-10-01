using System.Collections.Generic;

namespace Demo_NTierCRUD
{
    public interface IDataService
    {
        IEnumerable<Character> ReadAll();
        void WriteAll(IEnumerable<Character> characters);
    }
}
