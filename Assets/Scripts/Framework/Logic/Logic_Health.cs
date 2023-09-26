using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logic_Health : ILogic
{

    [SerializeField] private Model_Health model_health;

    Presenter_Health health;

    public Logic_Health(Model_Health model_health, View_Health view_Health)
    {
        this.model_health = model_health;

        health = new Presenter_Health(model_health, view_Health);
        health.Present();

        GlobalEvents.OnHealthReduced += OnHealthReduced;

    }

    public void Start()
    {
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            model_health.health = Mathf.Clamp(model_health.health - model_health.healthValue * Time.deltaTime, 0, model_health.maxHealth);
            health.Present();
        }
        if (Input.GetKey(KeyCode.D))
        {
            model_health.health = Mathf.Clamp(model_health.health + model_health.healthValue * Time.deltaTime, 0, model_health.maxHealth);
            health.Present();
        }
    }

    private void OnHealthReduced(float amount)
    {
        model_health.health = Mathf.Clamp(model_health.health - amount, 0, model_health.maxHealth);
        health.Present();

        if (model_health.health <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

}
