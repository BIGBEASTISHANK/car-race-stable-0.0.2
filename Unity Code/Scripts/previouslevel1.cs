using UnityEngine;
using UnityEngine.SceneManagement;

public class previouslevel1 : MonoBehaviour
{
    public void NextGame(){
        SceneManager.LoadScene("Level 01");
    }
}
