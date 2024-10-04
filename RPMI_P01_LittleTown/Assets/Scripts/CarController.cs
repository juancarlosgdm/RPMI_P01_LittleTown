using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] private float forwardSpeed;

    [SerializeField] private float movementSpeed;

    [SerializeField] private int score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update se llama en cada uno de los frames
    void Update()
    {
        // Imprime por consola el texto update
        // Debug.Log("update");

        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            score -= 10;
        }
        if (collision.gameObject.CompareTag("Dumpster"))
        {
            score -= 5;
        }
    }
}
