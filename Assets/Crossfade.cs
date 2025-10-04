using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator crossFade;

    void Update()
    {
        if(DroneSpawn.AliveCurrentDrones <= 0 && DroneSpawn.allDronesSpawn)
        {
            StartCoroutine(LoadNextScene());
            Debug.Log("Loading");
                
        }
    }

    IEnumerator LoadNextScene()
    {
        // Trigger Fade Out
        crossFade.SetTrigger("Fade In");

        // Wait for fade out to finish (match animation length, e.g., 1s)
        yield return new WaitForSeconds(1f);

        // Load the next scene
        SceneManager.LoadScene("Boss");

        crossFade.SetTrigger("Fade Out");
    }
}
