using UnityEngine;
using UnityEngine.UI;

public class View_Health : MonoBehaviour
{

    [SerializeField]
    private Image healthBar;
    
    public void UpdateHealthBar(float min, float max)
    {
        healthBar.fillAmount = min / max;
    }

}
