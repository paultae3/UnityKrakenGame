using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public GameObject _player;

    public Dialogue _localDialogue;

    public void OnTriggerEnter(Collider other)
    {

        _player = GameObject.FindWithTag("Player");

        DialogueController dialogueController = other.gameObject.GetComponent<DialogueController>();

        if (_player != null)
        {
            dialogueController.StartDialogue(_localDialogue);
        }

    }

}
