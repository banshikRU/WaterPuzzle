using System.Collections;
using dotmob;
using UnityEngine;

public class Splash : MonoBehaviour
{
    private void Start()
    {
        GameManager.LoadScene("MainMenu");
    }
    //private IEnumerator Start()
    //{
    //    if (!AdsManager.HaveSetupConsent)
    //    {
    //        SharedUIManager.ConsentPanel.Show();
    //        yield return new WaitUntil(() => !SharedUIManager.ConsentPanel.Showing);
    //    }

    //    GameManager.LoadScene("MainMenu");
    //}
}