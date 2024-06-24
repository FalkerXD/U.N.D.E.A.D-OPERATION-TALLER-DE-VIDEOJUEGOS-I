using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeechBubble : MonoBehaviour
{
    public Text speechText; // Referencia al componente de texto
    public GameObject speechPanel; // Referencia al panel del globo
    public float displayTime = 3f; // Tiempo que el globo se mostrar�

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
        StartCoroutine(HideAfterTime(displayTime));
    }

    // Coroutine para ocultar el globo despu�s de un tiempo
    private IEnumerator HideAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        speechPanel.SetActive(false);
    }

    // M�todo para ocultar el globo de conversaci�n manualmente
    public void HideSpeechBubble()
    {
        speechPanel.SetActive(false);
    }
}
