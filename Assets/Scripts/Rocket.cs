using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Boost();
        Directions();

    }

    private void Boost()
    {

        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.up * speed);

        }
    }

    private void Directions()
    {
        rb.freezeRotation = true;
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.left * rotateSpeed * Time.deltaTime);
        }
        rb.freezeRotation = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "B")
        {

            Debug.Log("completed level 1");
        }

    }
}