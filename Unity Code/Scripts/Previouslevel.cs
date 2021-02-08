using UnityEngine;
using UnityEngine.SceneManagement;

public class Previouslevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene( - 1 );
        Debug.Log("Fool This is just test game. Go and sleep.");
    }
}
