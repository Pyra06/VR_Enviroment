using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform viewer;
    public GameObject particleEffect;
public void TeleportViewer()
    {
        particleEffect.SetActive(true);
        viewer.transform.position = new Vector3(transform.position.x, transform.position.y + 0.882f, transform.position.z);
    }
}
