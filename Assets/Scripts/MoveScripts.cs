using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rigid;
    private float moveSpeed = 10.0f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x , transform.position.y + moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
    }
}
