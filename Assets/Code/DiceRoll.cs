using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class DiceRoll : MonoBehaviour
{
    public TMP_Text RollResults = null;
    private float Die1 = 0.0f;
    private float Die2 = 0.0f;
    public SkillBuff isBuffed;

    InputAction attackAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.IsPressed())
        {
            Roll();
        }
    }

    void Roll()
    {
        if (attackAction.IsPressed())
        {
            Die1 = Random.Range(1, 7);
            Die2 = Random.Range(1, 7);

            if (isBuffed == true)
            {
                RollResults.text = "Rolled: " + Die1 + ", " + Die2 + ", 2";
            }
            else
            {
                RollResults.text = "Rolled: " + Die1 + ", " + Die2 + ", 0";
            }
        }
    }

}
