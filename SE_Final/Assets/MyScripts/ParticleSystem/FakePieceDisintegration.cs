// I created a disintagrating particle effect following the instructions provided during Lecture 5, as well as the following tutrial: https://www.youtube.com/watch?v=rL3H2ionaKg
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(XRGrabInteractable))]
public class DisintegrationEffect : MonoBehaviour
{
    public ParticleSystem disintegrationParticles;

    private XRGrabInteractable grabInteractable;

    voide Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEnter.AddListener(StartDisintegration);
        grabInteractable.onSelectExit.AddListener(StopDisintegration);
    }

    private void StartDisintegration(SelectEnterEventArgs args)
    {
        disintegrationParticles.Play();
    }

    private void StopDisintegration(SelectExitEventArgs args)
    {
        disintegrationParticles.Stop();
    }

    private void OnDestroy()
    {
        grabInteractable.onSelectEnter.RemoveListener(StartDisintegration);
        grabInteractable.onSelectExit.RemoveListener(StopDisintegration);
    }
}
