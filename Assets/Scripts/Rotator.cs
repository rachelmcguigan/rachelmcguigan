using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()//not using forces so can use update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
