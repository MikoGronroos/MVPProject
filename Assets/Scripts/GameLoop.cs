using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    private List<ILogic> logic = new List<ILogic>();

    void Start()
    {
        foreach (var item in FindObjectsOfType<BehaviourMono>())
        {
            logic.Add(item.iLogic);
        }
    }

    void Update()
    {
        foreach (var update in logic)
        {
            update.Update();
        }
    }
}
