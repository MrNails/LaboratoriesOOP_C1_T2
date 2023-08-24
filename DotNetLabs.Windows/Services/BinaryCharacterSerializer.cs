using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using DotNetLabs.Windows.Views.UserControls;

namespace DotNetLabs.Windows.Services;

public sealed class BinaryCharacterSerializer : ICharacterSerializer
{
    public string FileName { get; set; }
    
    public void SerializeCharacter(IEnumerable<Character> characters)
    {
        using (var fStream = new FileStream(FileName, FileMode.OpenOrCreate))
        using (var binWriter = new BinaryWriter(fStream))
        {
            binWriter.Write(characters.Count());
            foreach (var character in characters)
            {
                binWriter.Write(character.CharacterToDraw);
                binWriter.Write(character.Color.ToString());
                binWriter.Write(character.Font.ToString());
                binWriter.Write(character.Center.X);
                binWriter.Write(character.Center.Y);
            }
        }
    }

    public IEnumerable<Character> DeserializeCharacter()
    {
        using (var fStream = new FileStream(FileName, FileMode.OpenOrCreate))
        using (var binReader = new BinaryReader(fStream))
        {
            var amountOfElements = binReader.ReadInt32();
            var result = new List<Character>();

            for (int i = 0; i < amountOfElements; i++)
            {
                result.Add(new Character(binReader.ReadChar(), 
                    new SolidColorBrush((Color)ColorConverter.ConvertFromString(binReader.ReadString())),
                    new FontFamily(binReader.ReadString())
                ) { Center = new Point(binReader.ReadDouble(), binReader.ReadDouble()) });
            }

            return result;
        }
    }
}