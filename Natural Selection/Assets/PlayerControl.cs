using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private GameObject foodToSpawn;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (CurrentScene.Instance().GetCollider().ClosestPoint(mousePositionInWorld) == mousePositionInWorld)
            {
                Instantiate(foodToSpawn, mousePositionInWorld, Quaternion.identity);
            }
        }
    }
}
