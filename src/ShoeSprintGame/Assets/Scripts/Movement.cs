using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7f;
    public float lineChangeSpeed = 5f;
    private Rigidbody rb;
    private Lines currentLine = Lines.DEFAULT;
    private bool isMoving = false;
    private Vector3 targetPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FreezeRotation();
    }

    void Update()
    {
        JumpListener();
        SideMovementListener();
        ForwardBoostListener();
    }

    void FixedUpdate()
    {
        if (!isMoving) // Only move forward if not moving to the side
        {
            float zValue = Time.deltaTime * speed;
            transform.Translate(0, 0, zValue);
        }
    }
    private void ForwardBoostListener()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speed += 5f;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            speed -= 5f;
        }
    }
    private void FreezeRotation()
    {
        if (rb == null)
        {
            Debug.LogError("Rigidbody not found");
        }
        rb.freezeRotation = true;
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
        if (isMoving) // if already moving, ignore input
            return;

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentLine == Lines.LEFT)
                return;
            currentLine--;
            targetPosition = transform.position + Vector3.left * 2f + Vector3.forward * 2f;
            StartCoroutine(MoveToLine());
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLine == Lines.RIGHT)
                return;
            currentLine++;
            targetPosition = transform.position + Vector3.right * 2f + Vector3.forward * 2f;
            StartCoroutine(MoveToLine());
        }
    }

    IEnumerator MoveToLine()
    {
        isMoving = true;
        float t = 0f;
        Vector3 startPosition = transform.position;
        while (t < 1f)
        {
            t += Time.deltaTime * lineChangeSpeed;
            transform.position = Vector3.Lerp(startPosition, targetPosition, t);
            yield return null;
        }
        isMoving = false;
    }
}
