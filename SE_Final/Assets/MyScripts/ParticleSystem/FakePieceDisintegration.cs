// I created a disintagrating particle effect following the instructions provided during Lecture 5, as well as the following tutrial: https://www.youtube.com/watch?v=rL3H2ionaKg
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class TouchParticleEffect : MonoBehaviour
{
    public ParticleSystem particleEffect;

    private bool hasBeenTriggered = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasBeenTriggered && (collision.gameObject.CompareTag("LeftHand Controller") || collision.gameObject.CompareTag("RightHand Controller")))
        {
            particleEffect.Play();
            hasBeenTriggered = true;
        }
    }

    private void OnDestroy()
    {
        particleEffect.Stop();
    }
}



