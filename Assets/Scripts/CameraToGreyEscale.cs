using UnityEngine;

public class CameraToGreyEscale : MonoBehaviour
{
    private Camera camera;
    public float transitionTime = 5.0f;

    void Awake()
    {
        camera = camera.Main; 
    }

    void Start()
    {
        // llamar la coroutine cuando se quiera activar el fade
         StartCoroutine(TransitionToGrayscale());
    }

    IEnumerator TransitionToGrayscale() 
    {
        float elapsedTime = 0.0f;
        Color startColor = camera.backgroundColor;
        Color endColor = Color.gray;

        while (elapsedTime < transitionTime) {
        elapsedTime += Time.deltaTime;
        camera.backgroundColor = Color.Lerp(startColor, endColor, elapsedTime / transitionTime);
        yield return null;
    }
}

}