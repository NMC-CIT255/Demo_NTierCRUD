using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NTierCRUD
{
    public enum UserAction
    {
        None,
        ListAllCharacters,
        DisplayCharacterDetail,
        AddCharacter,
        UpdateCharacter,
        DeleteCharacter,
        QueryByAge,
        Quit
    }
}
