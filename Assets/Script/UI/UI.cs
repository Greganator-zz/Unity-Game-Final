using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text health;
    public Text missleAmmo;
    public Text hostilesRemain;
    private GameObject[] spawners;
    private GameObject[] hostiles;
    private int i_Lives;
    private int i_Health;
    private string s_MissleAmmo;
    private int i_HostilesRemain;
    private int i_HostileSpawnersRemain;
    public MenuOptions sceneOptions;



	// Update is called once per frame
	void Update () {
        //finds all values needed to update the text in the UI that resides withing various components
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            i_Health = GameObject.FindGameObjectWithTag("Player").GetComponent<DamagedBasic>().health;
            s_MissleAmmo = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShooting>().missileAmmo.ToString();
            i_Lives = GameObject.FindGameObjectWithTag("Respawn").GetComponent<PlayerSpawner>().numLives;
        }
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        hostiles = GameObject.FindGameObjectsWithTag("Hostile");
        i_HostilesRemain = hostiles.Length;
        i_HostileSpawnersRemain = spawners.Length;

        //Assings the values to the UI text
        health.text = "Health: " + i_Health + " | Lives: " + i_Lives;
        missleAmmo.text = "Missle Ammo: " + s_MissleAmmo;
        hostilesRemain.text = "Hostiles Remain /n" + "Spawners: " + i_HostileSpawnersRemain
            + "/n" + "Ships: " + i_HostilesRemain;
        EndGame();
    }

    void EndGame()
    {
        if(i_Health <= 0 && i_Lives <= 0)
        {
            sceneOptions.LoadScene(3);
        }
        else if(i_HostileSpawnersRemain <= 0 && i_HostilesRemain <= 0)
        {
            sceneOptions.LoadScene(2);
        }
    }
}
