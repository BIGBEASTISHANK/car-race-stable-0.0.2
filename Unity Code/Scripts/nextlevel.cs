using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public void NextGame(){
        SceneManager.LoadScene("Level 02");
    }
}
