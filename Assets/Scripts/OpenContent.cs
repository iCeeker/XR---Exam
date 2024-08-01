using UnityEngine;

public class OpenContent : MonoBehaviour
{
    // Open URL in Browser
    public void OpenURL (string url)
    {
        Application.OpenURL(url);
    }
}
