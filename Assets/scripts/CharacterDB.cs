using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Menu pour choisir une relique

[CreateAssetMenu]
public class CharacterDB : ScriptableObject
{
    public Character[] character;

    public int CharacterCount{
        get{
            return character.Length; //retourne le nombre de reliques 
        }
    }
public Character GetCharacter(int index)
{
    return character[index];
}

}
