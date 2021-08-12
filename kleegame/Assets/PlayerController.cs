using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int getFIshNum;
    // Start is called before the first frame update
    void Start()
    {
        getFIshNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float dy = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(dx, 0, 0);
        transform.Translate(0, dy, 0);
    }
}
