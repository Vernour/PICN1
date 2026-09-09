using UnityEngine;
using UnityEngine.InputSystem;

public class PLAYER : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed = 12;
    public float jumpspeed = 12;
    public float rotationSpeed = 12;
    bool canJump = false;
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

            rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Force);

            //transform.position += Vector3.forward * speed * Time.deltaTime;

        }
        if (Keyboard.current.sKey.IsPressed())
        {

            rigidbody.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.Force);
            //  transform.position += Vector3.back* speed * Time.deltaTime;

        }

        if (Keyboard.current.aKey.IsPressed())
        {

            rigidbody.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Force);
            // transform.position += Vector3.up* speed * Time.deltaTime;

        }
        if (Keyboard.current.dKey.IsPressed())
        {

            rigidbody.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Force);
            //  transform.position += Vector3.down * speed * Time.deltaTime;

            // transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);



        }

        if (Keyboard.current.spaceKey.IsPressed()&& canJump)
        {
            rigidbody.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);

        }

    }
    private void OnCollisionEnter(Collision Collision)
    {

        if (Collision.gameObject.name == "GROUND")
        {
            canJump = true;

        }
    }

    private void OnCollisionExit(Collision Collision)
    {

        if (Collision.gameObject.name == "GROUND")
        {
            canJump = false;


        }
    }

    private void OnCollisionStay(Collision Collision)
    {

        if (Collision.gameObject.name == "GROUND")
        {
            canJump = true;

        }

    }

}
