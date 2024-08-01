using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMarkerButton : MonoBehaviour
{
    // Find Markers
    public GameObject marker1;
    public GameObject marker2;
    public GameObject marker3;
    public GameObject marker4;
    public GameObject marker5;



    public void ToggleHomeButton()
    {

        // Find Content
        GameObject[] contents = GameObject.FindGameObjectsWithTag("Content");

        // Disable Content 
        foreach (GameObject content in contents)
             {
                  content.SetActive(false);
             }

        // Enable Markers
        marker1.SetActive(true);
        marker2.SetActive(true);
        marker3.SetActive(true);
        marker4.SetActive(true);
        marker5.SetActive(true);

        // Weder Liste noch foreach Schleife hat bei den Markern funktioniert. Daher die unsaubere Lösung.

    }

}
