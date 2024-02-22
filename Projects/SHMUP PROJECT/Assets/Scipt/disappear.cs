using UnityEngine;
using UnityEngine.UI;

public class TextDisappearing : MonoBehaviour
{
    bool started = false;
    private Text textComponent;
    public float disappearanceSpeed = 1f;

    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            started = true;
        }

        if (started)
        {
            Color currentColor = textComponent.color;
            float alpha = Mathf.Clamp01(currentColor.a - disappearanceSpeed * Time.deltaTime);
            textComponent.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);

            if (alpha <= 0f)
            {
                started = false;
            }
        }
    }
}
