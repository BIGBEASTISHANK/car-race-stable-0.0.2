using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene( + 1 );
        Debug.Log("Loaded Next Level");
    }
}
