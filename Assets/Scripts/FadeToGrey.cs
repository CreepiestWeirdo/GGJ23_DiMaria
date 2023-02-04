using UnityEngine;

public class FadeToGrey : MonoBehaviour
{
    private Material material;
    private float fadeSpeed = 0.05f;
    private float targetValue = 0f;
    private float currentValue = 0f;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (currentValue != targetValue)
        {
            //con fadeSpeed se controla la velocidad de transición
            currentValue = Mathf.Lerp(currentValue, targetValue, fadeSpeed * Time.deltaTime);
            material.color = new Color(currentValue, currentValue, currentValue);
        }
    }

    public void StartFade()
    {
        targetValue = 1f;
    }

    public void ResetFade()
    {
        targetValue = 0f;
    }

    // Agregar ek script a los objetos a afectar y llamar StartFade y ResetFade en el momento que se desee que inicie y termine.

    
}