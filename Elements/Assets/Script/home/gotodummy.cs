using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotodummy : MonoBehaviour {
    public void Push()
    {
        SceneManager.LoadScene("dummy");
    }

}
