using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class DiceRoll : MonoBehaviour
{
    public TMP_Text RollResults = null;
    private float Die1 = 0.0f;
    private float Die2 = 0.0f;

    InputAction attackAction;


    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");

        //buffobject = GameObject.Find("SkillBuff").GetComponent<isBuffed>();
    }

    void Update()
    {
        //if (attackAction.IsPressed())
        //{
            //Roll();
        //}
    }

    private void OnTriggerStay(Collider other)
    {
        if (attackAction.WasPressedThisFrame())
        {
            Die1 = Random.Range(1, 7);
            Die2 = Random.Range(1, 7);

            RollResults.text = "Rolled: " + Die1 + ", " + Die2;
        }
    }

}
