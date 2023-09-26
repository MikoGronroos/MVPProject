using UnityEngine;

public class Logic_Target : ILogic
{

    private Target targetPrefab = default;

    private float maxX = 5.2f;
    private float minX = -5.2f;
    private float maxY = 3.5f;
    private float minY = -2.5f;

    private Target currentTarget;

    public Logic_Target(Target targetPrefab)
    {
        this.targetPrefab = targetPrefab;
    }

    public void Start()
    {
    }

    public void Update()
    {
        if (currentTarget == null)
        {
            SpawnTarget();
        }
    }

    private void SpawnTarget()
    {
        Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        currentTarget = GameObject.Instantiate(targetPrefab, pos, Quaternion.identity);
        currentTarget.Callback += ClearTarget;
    }

    private void ClearTarget(Target target)
    {
        GameObject.Destroy(target.gameObject);
        GlobalEvents.OnHealthReduced?.Invoke(10);
    }

}
