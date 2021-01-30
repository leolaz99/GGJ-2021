﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inventory;
    [SerializeField] private string dialogue;
    [SerializeField] public Text dialogeText;
    public bool isDialogueActive;
    [SerializeField] KeyCode continueKey;
    // Start is called before the first frame update
    public void StartDialogue(GameObject other)
    {
        /*
        Debug.Log("a");
        player = GameObject.Find("Player");
        inventory = player.GetComponent<Inventory>();
        dialogue = inventory.itemInfos[inventory.index].dialogueText;
        
        */
        gameObject.SetActive(true);
        dialogue = other.GetComponent<ItemInfo>().dialogueText;
        dialogeText.text = dialogue;
        isDialogueActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(continueKey) && isDialogueActive == true)
        {
            gameObject.SetActive(false);
        } else
        {
            isDialogueActive = true;
        }
    }
}
