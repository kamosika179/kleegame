using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishTouch : MonoBehaviour
{
    public string playerTag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == playerTag)
        {
            Debug.Log("ãõÇ…êGÇÍÇƒÇ¢Ç‹Ç∑");
            GameObject game = collision.gameObject;
            transform.root.gameObject.GetComponent<FishBehave>().FishDetect(game);
        }
    }
}
