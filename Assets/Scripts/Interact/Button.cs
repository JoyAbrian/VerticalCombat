using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : Interactable
{
    InputManager inputManager;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Design the interaction using code
    protected override void Interact()
    {
        Vector3 targetPosition = new Vector3(-5, 0, -15);
        player.GetComponent<CharacterController>().Move(targetPosition - player.transform.position);
    }
}