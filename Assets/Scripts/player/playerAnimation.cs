using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    playerEventController eventController;
    Animator animator;
    
    void Start()
    {
        eventController = gameObject.GetComponent<playerEventController>();
        animator = gameObject.GetComponent<Animator>();

        eventController.onJumpEvent.AddListener(onJump);
        eventController.onFallEvent.AddListener(onFall);
        eventController.onDeathEvent.AddListener(onDeath);
    }

    private void onJump()
    {
        animator.SetBool("jumping", true);
    }
    private void onDeath()
    {
        animator.SetTrigger("hit");
    }
    private void onFall()
    {
        animator.SetBool("jumping", false);
    }
}
