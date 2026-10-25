using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class SkillBuff : MonoBehaviour
{
    public bool isBuffed = false;
    public TMP_Text BuffText = null;

    InputAction interactAction;

    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    void Update()
    {
        //if (interactAction.IsPressed())
        //{
            //GetBuff();
        //}
    }

    private void OnTriggerStay()
    {
        if (interactAction.WasPressedThisFrame())
        {
            if (!isBuffed)
            {
                isBuffed = true;
            }
            else
            {
                isBuffed = false;
            }

            BuffText.text = "Buffed? " + isBuffed;
        }
        
    }

}
