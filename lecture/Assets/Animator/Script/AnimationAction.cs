using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void kick()
    {
        animator.Play("MMA Kick");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
