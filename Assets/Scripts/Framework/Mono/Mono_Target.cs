using UnityEngine;

public class Mono_Target : BehaviourMono
{

    [SerializeField] private Target targetPrefab;

    private void Awake()
    {
        iLogic = new Logic_Target(targetPrefab);
    }

}
