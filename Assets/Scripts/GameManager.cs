using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Vector3 respawnPosition;

    public GameObject playerDeathEffect;
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        respawnPosition = PlayerController.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn() {
        StartCoroutine(RespawnCo());
    }

    private IEnumerator RespawnCo() {
        PlayerController.instance.gameObject.SetActive(false);
        CameraController.instance.theCMBrain.enabled = false;
        UIManager.instance.fadeToBlack = true;
        Instantiate(playerDeathEffect, PlayerController.instance.transform.position + new Vector3(0f, 1f, 0f), PlayerController.instance.transform.rotation);

        yield return new WaitForSeconds(1.5f);

        UIManager.instance.fadeFromBlack = true;
        CameraController.instance.theCMBrain.enabled = true;
        PlayerController.instance.transform.position = respawnPosition;
        PlayerController.instance.gameObject.SetActive(true);

        HealthManager.instance.resetHealth();
    }

    public void SetSpawnPoint(Vector3 newRespawnPoint) {
        respawnPosition = newRespawnPoint;
    }
}
