using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionSystem : MonoBehaviour
{
    private InputAction interactAction;
    private IInteractable interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactAction = InputManager.Instance.GetControlMapping().PlayerCharacter.Interaction;
        interactAction.performed += InteractionPerformedInputHandler;
    }

    public void SetInteractible(IInteractable interactable) {
        this.interactable = interactable; 
    }

    public void UnsetInteractable(IInteractable interactable){
        if(this.interactable == interactable) {
            this.interactable = null;
        }
    }

    private void InteractionPerformedInputHandler(InputAction.CallbackContext context){
        interactable?.Interact();
    }

    // Update is called once per frame
    private void OnEnable(){
        interactAction?.Enable();
    }

    private void OnDisable(){
        interactAction?.Disable();
    }
}
