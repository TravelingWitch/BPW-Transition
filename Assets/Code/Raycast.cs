using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    //set mask to the mask of the object you
    //want to look at in the editor.
    public LayerMask mask;
    public BoxCollider volume01;
    public Animator auroraAnimator;
    private float lookingTimeEvent;
    private bool startEvent;

    private void Update()
    {
        volume01.enabled = false; 

        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity, mask))
        {
            var obj = hit.collider.gameObject;

            Debug.Log($"looking at {obj.name}", this);

            lookingTimeEvent += Time.deltaTime;
        }

        if (lookingTimeEvent >= 8)
        {
            AnimationEvent();
        }
    }
    void AnimationEvent()
    {
        if (startEvent != true)
        {
            startEvent = true;
            auroraAnimator.SetTrigger("RaycastTrigger");

            volume01.enabled = true;
            Debug.Log("lightcast");
        }

    }
}
