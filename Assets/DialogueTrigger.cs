
using UnityEngine;
using UnityEngine.UI;
public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    // Update is called once per frame
    public bool isInRange;

    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.C))
        {
            TriggerDialogue();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("player"))
        {
            isInRange = true; //si l'heros entre dans la zone de dialogue
        }

    }
        private void OnTriggerExit2D(Collider2D collision){
               if(collision.CompareTag("player"))
        {
            isInRange = false; //si l'heros quitte la zone de dialogue
        }
    }
    void TriggerDialogue(){
            DialogueManager.instance.StartDialogue(dialogue);
        }
}
