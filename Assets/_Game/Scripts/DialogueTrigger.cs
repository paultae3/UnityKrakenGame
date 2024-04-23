using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public GameObject _player;

    public void OnTriggerEnter(Collider other)
    {

        _player = GameObject.FindWithTag("Player");

        DialogueController dialogueController = other.gameObject.GetComponent<DialogueController>();

        Dialogue dialogue = other.gameObject.GetComponent<Dialogue>();

        if (_player != null)
        {
            dialogueController.StartDialogue(Dialogue dialogue);
        }

    }

}
