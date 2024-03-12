using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // message displayed to player when looking at interactable
    public string promptMessage;
    
    // this function will be called from player
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // template function
    }
}
