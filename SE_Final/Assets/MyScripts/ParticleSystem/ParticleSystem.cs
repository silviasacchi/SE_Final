//  I'm creating a script to trigger the particle system whenver it's grabed by the player. I'm following Lecture 5 tutorials.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))] // This is a script that is required to be attached to the object that is grabable by the player.
public class GrabParticleEffect : MonoBehaviour
{
    public ParticleSystem particleEffect;

    private XRGrabInteractable grabInteractable;

    // When the object is grabbed, the particle effect will play.
    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(StartParticleEffect);
    }

    private void StartParticleEffect(SelectEnterEventArgs args)
    {
        particleEffect.Play();
    }

    private void OnDestroy()
    {
        grabInteractable.selectEntered.RemoveListener(StartParticleEffect);
    }
}
