using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class SkillBuff : MonoBehaviour
{
    public bool isBuffed = false;
    private float Buff = 2.0f;
    public TMP_Text BuffText = null;

    InputAction interactAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    // Update is called once per frame
    void Update()
    {
        if (interactAction.IsPressed())
        {
            GetBuff();
        }
    }

    private void GetBuff()
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
