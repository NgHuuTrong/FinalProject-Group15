using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public GameObject cpOn, cpOff;

    // Start is called before the first frame update
    void Start()
    {
        if (cpOff != null)
            cpOff.SetActive(true);
        if (cpOn != null)
            cpOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            GameManager.instance.SetSpawnPoint(transform.position);
            if (cpOff != null) {
                cpOff.SetActive(false);
            }
            if (cpOn != null) {
                cpOn.SetActive(true);
            }
        }
    }

}
