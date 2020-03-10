using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatPrefab : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            var go = Instantiate(prefab) as GameObject;

            go.transform.position = new Vector3(0, 0, 0);
        }
    }
}
