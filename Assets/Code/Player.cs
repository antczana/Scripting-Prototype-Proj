using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    InputAction moveAction;
    //InputAction interactAction;
    //InputAction attackAction;

    private CharacterController controller;
    private float speed = 5.0f;

    //private bool isBuffed = false;
    //private float SkillBuff = 2.0f;
    //public TMP_Text BuffText = null;

    //public TMP_Text RollResults = null;
    //private float Die1 = 0.0f;
    //private float Die2 = 0.0f;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        //interactAction = InputSystem.actions.FindAction("Interact");
        //attackAction = InputSystem.actions.FindAction("Attack");

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector2 direction = new Vector2(moveValue.x * Time.deltaTime, moveValue.y * Time.deltaTime);
        controller.Move(direction * speed);
        Bounds();

        //if (interactAction.IsPressed())
        //{
            //GetBuff();
        //}

        //if (attackAction.IsPressed()) 
        //{
            //Roll();
        //}
    }

    //private void GetBuff()
    //{
        //if (!isBuffed)
        //{
            //isBuffed = true;
        //}
        //else
        //{
            //isBuffed = false;
        //}

        //BuffText.text = "Buffed? " + isBuffed;
    //}

    //void Roll()
    //{
        //if (attackAction.IsPressed())
        //{
            //Die1 = Random.Range(1, 6);
            //Die2 = Random.Range(1, 6);

            //if (isBuffed == true)
            //{
                //RollResults.text = "Rolled: " + Die1 + ", " + Die2 + ", " + SkillBuff;
            //}
            //else
            //{
                //RollResults.text = "Rolled: " + Die1 + ", " + Die2 + ", 0";
            //}
        //}
    //}

    public void Normalize()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
    }

    private void Bounds()
    {
        //left bound
        if (transform.position.x < -10.89f)
        {
            transform.position = new Vector3(-10.89f, transform.position.y, -1.0372f);
        }

        //right bound
        else if (transform.position.x > -2.17f)
        {
            transform.position = new Vector3(-2.17f, transform.position.y, -1.0372f);
        }
    }

}
