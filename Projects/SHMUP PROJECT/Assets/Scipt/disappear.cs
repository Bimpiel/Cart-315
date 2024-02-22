using UnityEngine;
using UnityEngine.UI;

public class TextDisappearing : MonoBehaviour
{
    private Text textComponent;

    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            textComponent.enabled = !textComponent.enabled;
        }
    }
}
