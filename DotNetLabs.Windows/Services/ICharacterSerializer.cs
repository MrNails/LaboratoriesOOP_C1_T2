using System.Collections.Generic;
using DotNetLabs.Windows.Views.UserControls;

namespace DotNetLabs.Windows.Services;

public interface ICharacterSerializer
{
    void SerializeCharacter(IEnumerable<Character> characters);
    IEnumerable<Character> DeserializeCharacter();
}