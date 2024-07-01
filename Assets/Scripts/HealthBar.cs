using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarImage; // Referencia al componente Image de la barra de vida

    public void SetMaxHealth(int health)
    {
        healthBarImage.fillAmount = 1f; // La barra est� llena al inicio
    }

    public void SetHealth(int health, int maxHealth)
    {
        healthBarImage.fillAmount = (float)health / maxHealth; // Actualiza la cantidad de llenado de la barra
    }
}
