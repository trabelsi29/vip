﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
public CharacterDB characterDataB;
public Text nameText;
public SpriteRenderer artworkSprite;

private int selectedOption = 0;
void Start()
{

}

public void NextOption()
{
    selectedOption++;
    if(selectedOption >= characterDataB.CharacterCount)
    {
        selectedOption = 0;
    }
    UpdateCharacter(selectedOption);

}

public void BackOption()
{
    selectedOption--;
    if(selectedOption < 0)
    {
        selectedOption = characterDataB.CharacterCount - 1 ;
    }
    UpdateCharacter(selectedOption);
}



private void UpdateCharacter(int selectedOption)
{
    Character character = characterDataB.GetCharacter(selectedOption);
    artworkSprite.sprite = character.characterSprite;
    nameText.text = character.characterName;
}
}
