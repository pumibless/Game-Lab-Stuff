using System.Collections;
using UnityEngine;

public class Start : MonoBehaviour {

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    
}
