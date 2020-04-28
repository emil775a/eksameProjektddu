using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{

    PlayerControl controls;

    Vector2 move;
    Vector2 rotate;
    private void Awake()
    {

        controls = new PlayerControl();

        controls.Gameplay.grow.performed += ctx => Grow();

        controls.Gameplay.move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.rotate.canceled += ctx => rotate = Vector2.zero;
    }

    void Grow()
    {
        transform.localScale *= 1.1f;

    }

    private void Update()
    {
        Vector2 m = new Vector2(-move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);

        Vector2 r = new Vector2(-rotate.y, -rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
