using UnityEngine;
using UnityEngine.UI;

public class SpeechBubble : MonoBehaviour
{
    public Text speechText; // Referencia al componente de texto
    public GameObject speechPanel; // Referencia al panel del globo

    void Start()
    {
        // Aseg�rate de que el globo de conversaci�n est� oculto al inicio
        speechPanel.SetActive(false);
    }

    // M�todo para mostrar el globo de conversaci�n
    public void ShowSpeechBubble(string text)
    {
        speechText.text = text;
        speechPanel.SetActive(true);
    }

    // M�todo para ocultar el globo de conversaci�n
    public void HideSpeechBubble()
    {
        speechPanel.SetActive(false);
    }
}
