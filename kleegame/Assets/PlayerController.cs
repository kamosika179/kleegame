using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int getFIshNum;
    public Text score;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        getFIshNum = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float dy = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(dx, 0, 0);
        transform.Translate(0, dy, 0);
    }

    public void GetFish()
    {
        getFIshNum++;
        audioSource.Play();
        score.text = "Score:" + getFIshNum.ToString();
        
    }
}
