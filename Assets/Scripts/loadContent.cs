using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadContent : MonoBehaviour
{
    // Set Content that needs to be loaded
    public GameObject content;

        private void OnMouseUpAsButton()
    {
        // Find Marker
        GameObject[] markers = GameObject.FindGameObjectsWithTag("Marker");
          
        // Disable Marker 
        foreach (GameObject marker in markers)
        {
            marker.SetActive(false);
        }

         content.SetActive(true);
  }
}
