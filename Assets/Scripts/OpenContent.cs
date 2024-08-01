using UnityEngine;

public class OpenContent : MonoBehaviour
{
    // Open URL in Browse
    public void OpenURL (string url)
    {
        Application.OpenURL(url);
    }
}
