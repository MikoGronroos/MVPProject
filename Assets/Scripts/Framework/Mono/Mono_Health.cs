using UnityEngine;

public class Mono_Health : BehaviourMono
{

    [SerializeField] private Model_Health model_health;
    [SerializeField] private View_Health view_Health;


    private void Awake()
    {
        iLogic = new Logic_Health(model_health, view_Health);
    }

}
