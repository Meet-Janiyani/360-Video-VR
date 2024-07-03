using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInpt : MonoBehaviour
{
    // XRIDefaultInputActions action;
    Controller action; 
    [SerializeField] GameObject canvas;

    private void Awake()
    {
        action = new Controller();
    }

    void OnEnable()
    {
        action.Enable();
        action.Action.Button.performed += EnableDisableUI;
    }

    private void OnDisable()
    {
        action.Disable();
        action.Action.Button.performed -= EnableDisableUI;
    }


    public void EnableDisableUI(InputAction.CallbackContext context)
    {
        canvas.SetActive(!canvas.activeSelf);   
    }
}
