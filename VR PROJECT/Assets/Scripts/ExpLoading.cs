using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpLoading : MonoBehaviour
{
    public Animator animator;
    public GameObject expOn, expOff, vidOn, vidOff;
    public void ExpStart()
    {
        expOn.SetActive(true);
        animator.SetBool("CinemaOpen",true);
        expOff.SetActive(false);
    }

    public void videoStart()
    {
        vidOn.SetActive(true);
        vidOff.SetActive(false);
    }
}
