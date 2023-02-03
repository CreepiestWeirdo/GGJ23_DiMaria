using UnityEngine;

public class GrayscaleFade : MonoBehaviour
{
    public float timeThreshold = 10.0f; // tiempo antes de que se aplique el efecto
    public float grayscaleAmount = 1.0f; // cantidad de escala de grises a aplicar
    public Material grayscaleMaterial; // material con el shader de escala de grises

    private float timeElapsed = 0.0f; // tiempo transcurrido
    private Camera mainCamera; // cámara principal del juego

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeThreshold)
        {
            mainCamera.gameObject.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
            mainCamera.gameObject.GetComponent<Camera>().RenderWithShader(grayscaleMaterial.shader, "RenderType");
        }
    }

    // Restablecer el tiempo y detener el efecto, se llama al momento que el personaje agarre un objeto
    public void ResetTime()
    {
        timeElapsed = 0.0f;
        mainCamera.gameObject.GetComponent<Camera>().ResetReplacementShader();
    }
}