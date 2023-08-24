using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;
using DotNetLabs.Windows.Views.UserControls;

namespace DotNetLabs.Windows.Services;

public sealed class XMLCharacterSerializer : ICharacterSerializer
{
    private static readonly string RootElementName = "Characters";
    
    public string FileName { get; set; }
    
    public void SerializeCharacter(IEnumerable<Character> characters)
    {
        var xDoc = new XDocument();
        var root = new XElement(RootElementName);

        foreach (var character in characters)
        {
            var currentCharacter = new XElement(nameof(Character));
            currentCharacter.Add(new XElement(nameof(Character.CharacterToDraw), character.CharacterToDraw),
                new XElement(nameof(Character.Color), character.Color.ToString()),
                new XElement(nameof(Character.Font), character.Font.ToString()),
                new XElement(nameof(Character.Center), 
                    new XElement(nameof(Point.X), character.Center.X),
                    new XElement(nameof(Point.Y), character.Center.Y))
                );
            
            root.Add(currentCharacter);
        }
        
        xDoc.Add(root);
        xDoc.Save(FileName);
    }

    public IEnumerable<Character> DeserializeCharacter()
    {
        var xDoc = XDocument.Load(FileName);
        var characters = xDoc.Element(RootElementName);

        var result = new List<Character>();
        foreach (var xElement in characters.Elements(nameof(Character)))
        {
            var characterToDraw = xElement.Element(nameof(Character.CharacterToDraw))?.Value;
            var color = (Color)ColorConverter.ConvertFromString(xElement.Element(nameof(Character.Color))?.Value);
            var font = new FontFamily(xElement.Element(nameof(Character.Font))?.Value);
            var positionXElement = xElement.Element(nameof(Character.Center));

            double.TryParse(positionXElement?.Element(nameof(Point.X))?.Value, out var x);
            double.TryParse(positionXElement?.Element(nameof(Point.Y))?.Value, out var y);
            
            result.Add(new Character(characterToDraw[0], new SolidColorBrush(color), font)
            {
                Center = new Point(x, y)
            });
        }

        return result;
    }
}