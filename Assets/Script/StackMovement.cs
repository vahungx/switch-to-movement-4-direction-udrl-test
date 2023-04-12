using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class StackMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed;
    public float speed;
    public float rotateSpeed;
    private float threshhold = 5;
    private Vector3 endMousePosition;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed =5;
        rotateSpeed = 20;
        speed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        /*CapsuleMouseInput();
        Run();
        Rotate();*/
        StackMouseInput();
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up * distance * rotateSpeed * Time.deltaTime);
    }
    public void Run()
    {

    }

    private void StackMovemontbyMouse()
    {
        
    }
    private void StackMouseInput()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            endMousePosition = Input.mousePosition;
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 v = Input.mousePosition - endMousePosition;
            Debug.Log("right");
            Debug.Log(Vector3.Angle(v, Vector3.right));
            Debug.Log("back");
            Debug.Log(Vector3.Angle(v, Vector3.back));
            Debug.Log("forward");
            Debug.Log(Vector3.Angle(v,Vector3.forward));
            Debug.Log("left");
            Debug.Log(Vector3.Angle(v, Vector3.left));
/*            // 4 case in this function:
            // 1. endPoint are in the 1st and 8th quadrants - rotate right = (1,0,0)
            if (Vector3.Angle(v, Vector3.right) <= 45) // cái này sai lè lè. Không dùng angle được rồi 
            {
                rb.velocity = Vector3.right * speed * Time.deltaTime;
            }
            // 2. endPoint are in the 2sd and 3rd quadrants - rotate up = (0,0,1)
            if (Vector3.Angle(endMousePosition, Vector3.forward) <= 45)
            {
                rb.velocity = Vector3.forward * speed * Time.deltaTime;
            }
            // 3. endPoint are in the 4th and 5th quadrants - rotate left = (-1,0,0)
            if (Vector3.Angle(endMousePosition, Vector3.left) <= 45)
            {
                rb.velocity = Vector3.left * speed * Time.deltaTime;
            }
            // 4. endPoint are in the 6th and 7th quadrants - rotate down = (0,0,-1)
            if (Vector3.Angle(endMousePosition, Vector3.back) <= 45)
            {
                rb.velocity = Vector3.back * speed * Time.deltaTime;
            }*/
            endMousePosition = Input.mousePosition;
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            distance = 0;
        }

    }
}
    