using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHeartBar : MonoBehaviour
{
    public GameObject heartPrefab;
    public float health, maxHealth;

    List<HealthHeart> hearts = new List<HealthHeart>();

    private void Start()
    {
        DrawHearts();
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealthHeart>();
    }

    public void DrawHearts()
    {
        ClearHearts();
        float maxHealthReminder = maxHealth % 2;
        int heartsToMake = (int)((maxHealth / 2) + maxHealthReminder);
        for (int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        for (int i = 0;i < hearts.Count; i++)
        {
            int heartStatusReminder = (int)Mathf.Clamp(health - (i * 2), 0, 2);
            hearts[i].SetHeartImage((HeartStatus)heartStatusReminder);
        }
    }
}
