using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDB : ScriptableObject
{
    public Character[] character;

    public int CharacterCount{
        get{
            return character.Length; //retourne nombre de personnages
        }
    }
public Character GetCharacter(int index)
{
    return character[index];
}

}
