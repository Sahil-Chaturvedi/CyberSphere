using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transtarget;

    void Update()
    {
        transform.position = transtarget.position;
    }
}
