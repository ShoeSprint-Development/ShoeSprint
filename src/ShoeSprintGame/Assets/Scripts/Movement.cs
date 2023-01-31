using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Lines currentLine = Lines.DEFAULT;

    //start
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FreezeRotation();
    }

    // Update is called once per frame
    void Update()
    {
        RunForward();
        JumpListener();
        SideMovementListener();
    }

    private void FreezeRotation()
    {
        if (rb == null)
        {
            Debug.LogError("Rigidbody not found");
        }
        rb.freezeRotation = true;
    }


    private void RunForward()
    {
        float zValue = Time.deltaTime * speed;
        transform.Translate(0, 0, zValue);
    }

    private void JumpListener()
    {
        if (transform.position.y > 0f)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    private void SideMovementListener()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentLine == Lines.LEFT)
                return;
            currentLine--;
            MoveToLine();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLine == Lines.RIGHT)
                return;
            currentLine++;
            MoveToLine();
        }
    }

    private void MoveToLine()
    {
        Vector3 targetPosition = transform.position;
        switch (currentLine)
        {
            case Lines.LEFT:
                targetPosition.x = -2f;
                break;
            case Lines.DEFAULT:
                targetPosition.x = 0f;
                break;
            case Lines.RIGHT:
                targetPosition.x = 2f;
                break;
        }
        transform.position = targetPosition;
    }

}
