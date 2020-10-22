using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestShot : MonoBehaviour
{
    static public int shot = 4;

    void Start()
    {
        PlayerPrefs.SetInt("Castle0", shot);
        PlayerPrefs.SetInt("Castle1", shot);
        PlayerPrefs.SetInt("Castle2", shot);
        PlayerPrefs.SetInt("Castle3", shot);
    }
    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        switch (MissionDemolition.currentLevel)
        {
            case 0:
                gt.text = "Fewest Shots: " + PlayerPrefs.GetInt("Castle0");
                break;
            case 1:
                gt.text = "Fewest Shots: " + PlayerPrefs.GetInt("Castle1");
                break;
            case 2:
                gt.text = "Fewest Shots: " + PlayerPrefs.GetInt("Castle2");
                break;
            case 3:
                gt.text = "Fewest Shots: " + PlayerPrefs.GetInt("Castle3");
                break;
        }
    }

    static public void NewBest()
    {
        if (MissionDemolition.shotsPerRound < shot)
        {
            switch (MissionDemolition.currentLevel)
            {
                case 0:
                    if (MissionDemolition.shotsPerRound < PlayerPrefs.GetInt("Castle0"))
                    {
                        PlayerPrefs.SetInt("Castle0", MissionDemolition.shotsPerRound);
                    }
                    break;
                case 1:
                    if (MissionDemolition.shotsPerRound < PlayerPrefs.GetInt("Castle1"))
                    {
                        PlayerPrefs.SetInt("Castle1", MissionDemolition.shotsPerRound);
                    }
                    break;
                case 2:
                    if (MissionDemolition.shotsPerRound < PlayerPrefs.GetInt("Castle2"))
                    {
                        PlayerPrefs.SetInt("Castle2", MissionDemolition.shotsPerRound);
                    }
                    break;
                case 3:
                    if (MissionDemolition.shotsPerRound < PlayerPrefs.GetInt("Castle3"))
                    {
                        PlayerPrefs.SetInt("Castle3", MissionDemolition.shotsPerRound);
                    }
                    break;
                default:
                    break;
            }
        }
        shot = 4;
    }
}
