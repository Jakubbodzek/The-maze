using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 2f;

    [SerializeField]
    private float jump = 4f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("SecondPlayerX");
        float yAxis = Input.GetAxisRaw("SecondPlayerY");

        Vector3 direction = new Vector3(xAxis, yAxis, 0f).normalized;

        transform.Translate(direction * speed * jump * Time.deltaTime);
    }
}
