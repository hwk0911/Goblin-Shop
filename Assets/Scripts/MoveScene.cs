using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update

    Button button;
        
    void Start()
    {
        this.button = this.transform.GetComponent<Button>();
        button.onClick.AddListener(OnClickMoveScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMoveScene ()
    {
        SceneManager.LoadScene("Mine_Cu");
    }
}
