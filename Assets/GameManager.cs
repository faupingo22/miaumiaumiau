using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CambiarEscena(int id)
    {
        SceneManager.LoadScene(id);
    }
    public void desblokcucsor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
