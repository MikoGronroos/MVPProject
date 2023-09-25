using UnityEngine;

public class HealthManager : MonoBehaviour
{

    [SerializeField] private float healthValue;

    [SerializeField] private Model_Health model_health;
    [SerializeField] private View_Health view_Health;

    private void Start()
    {
        Presenter_Health health = new Presenter_Health(model_health, view_Health);
        health.Present();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            model_health.health = Mathf.Clamp(model_health.health - 50 * Time.deltaTime, 0, model_health.maxHealth);
            Presenter_Health health = new Presenter_Health(model_health, view_Health);
            health.Present();
        }
        if (Input.GetKey(KeyCode.D))
        {
            model_health.health = Mathf.Clamp(model_health.health + 50 * Time.deltaTime, 0, model_health.maxHealth);
            Presenter_Health health = new Presenter_Health(model_health, view_Health);
            health.Present();
        }
    }

}
