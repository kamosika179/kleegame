using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishAnimationControl : MonoBehaviour
{
    Animator animator;
    FishBehave fishbehave;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.fishbehave = GetComponent<FishBehave>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fishbehave.direction.x > 0)
        {
            animator.SetBool("isRight", true);
        }
        else if(fishbehave.direction.x < 0)
        {
           // Debug.Log(fishbehave.direction.x);
            animator.SetBool("isRight", false);
        }
    }
}
