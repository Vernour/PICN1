using UnityEngine;
using UnityEngine.InputSystem;

public class PLAYER : MonoBehaviour
{

    public float speed = 12;
    public float rotationSpeed = 12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hi:D");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("yiipiie");

        if (Keyboard.current.wKey.IsPressed())
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;

        }
        if (Keyboard.current.sKey.IsPressed())
        {
            transform.position += Vector3.back
         * speed * Time.deltaTime;

        }

        if (Keyboard.current.aKey.IsPressed())
        {
            transform.position += Vector3.up
                    * speed * Time.deltaTime;

        }
        if (Keyboard.current.dKey.IsPressed())
        {
            transform.position += Vector3.down
                    * speed * Time.deltaTime;

           transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        }

    }
}
