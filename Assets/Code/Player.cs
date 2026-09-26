using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    InputAction moveAction;
    InputAction interactAction;
    private CharacterController controller;
    private float speed = 5.0f;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        interactAction = InputSystem.actions.FindAction("Interact");

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector2 direction = new Vector2(moveValue.x * Time.deltaTime, moveValue.y * Time.deltaTime);
        controller.Move(direction * speed);

        if (interactAction.IsPressed())
        {
            // your press code here
        }
    }

    public void Normalize()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
    }

}
