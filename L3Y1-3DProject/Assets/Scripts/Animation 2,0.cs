using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 
 
public class TriggerAnimation : MonoBehaviour
 
{

    public string animationName = "driving"; // Name of the animation you want to play
 
 
 
    void OnTriggerEnter(Collider other)
 
    {
 
        if (other.CompareTag("Player"))
 
        {
            Animator animator = GetComponent<Animator>(); // Get the Animator component
 
            animator.Play(animationName); // Play the animation
 
        }
 
    }
 
}