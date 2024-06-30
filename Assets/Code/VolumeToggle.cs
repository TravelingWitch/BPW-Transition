using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class VolumeToggle : MonoBehaviour
{
    public PostProcessVolume postProcessVolume; // Referentie naar het Post Process Volume

    private void Start()
    {
        // Zorg ervoor dat het post processing effect uitgeschakeld is aan het begin
        postProcessVolume.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Controleer of het object dat de collider binnengaat de speler is
        if (other.CompareTag("Player"))
        {
            postProcessVolume.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Controleer of het object dat de collider verlaat de speler is
        if (other.CompareTag("Player"))
        {
            postProcessVolume.enabled = false;
        }
    }
}

