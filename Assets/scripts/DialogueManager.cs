using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
  public Text nameText;
  public Text dialogueText;

  private Queue<string> sentences; //fil d'attente des phrases du dialogues

public static DialogueManager instance;

private void Awake()
{
    if(instance != null)
    {
        Debug.LogWarning(" Il y a plus d'une instance de DialogueManager dans la scène");
        return;
           }
    instance = this;
    sentences = new Queue<string>();
}

public void StartDialogue(Dialogue dialogue)
{
 nameText.text = dialogue.name;
 sentences.Clear();


foreach (string sentence in dialogue.sentences)
{
sentences.Enqueue(sentence);    
}
    DisplayNextSentence();
}

void DisplayNextSentence(){
    if (sentences.Count == 0)    //on teste si y a encore une phrase
    {
        EndDialogue();
        return;
    }
    string sentence = sentences.Dequeue();
    dialogueText.text = sentence;
}

void EndDialogue(){
Debug.Log("Fin du dialogue");
}

}
