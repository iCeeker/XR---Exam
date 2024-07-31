using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadContent : MonoBehaviour
{
    public GameObject marker;
    public GameObject content;
    public GameObject disableMarker1;
    public GameObject disableMarker2;   

        private void OnMouseUpAsButton()
        {
            marker.SetActive(false);
            content.SetActive(true);
            disableMarker1.SetActive(false);
            disableMarker2.SetActive(false);
        }
}
