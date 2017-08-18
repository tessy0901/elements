using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoHome : MonoBehaviour
{
    public void Push()
    {
        SceneManager.LoadScene("home");
    }

}
