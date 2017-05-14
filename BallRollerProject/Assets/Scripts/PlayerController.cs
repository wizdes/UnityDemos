using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public Text countText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        countText.text = "Count: " + 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(speed * new Vector3(moveHorizontal, 0.0f, moveVertical));
        countText.text = "Movement is: " + moveHorizontal;
    }
}
