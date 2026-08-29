using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    
    public GameObject Helppanel;

    private void Start()
    {
        Helppanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && !Helppanel.activeSelf)
        {
            Helppanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.H) && Helppanel.activeSelf)
        {
            Helppanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }


public void OpenHelp()
{
    Helppanel.SetActive(true);
    Time.timeScale = 0f;
}

}