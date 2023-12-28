using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
    //initialize all the relevant variables. Speed for player speed, count for objectgs counted then
    // text and rigidbody
    private Rigidbody rb;
    [SerializeField] private float speed;
    private int count;
    [SerializeField] private TMP_Text countText;
    // Start is called before the first frame update
    void Start()
    {
    // set everything
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCount();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
    // change direction according to input and add the forces
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);

    }
    // make pick up objects inactive if they collide with player and cahnge diplay text
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCount();
        }
    }
    // changes display text
    void SetCount ()
    {
        countText.text = "Collected: " + count.ToString();
    }
}
