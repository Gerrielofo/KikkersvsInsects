using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogInfoManager : MonoBehaviour
{
    public GameObject hud;

    public GameObject esmeeInfo;
    public GameObject bobInfo;
    public GameObject bertInfo;
    public GameObject paulInfo;

    public void EsmeeInfo()
    {
        esmeeInfo.SetActive(true);
        bobInfo.SetActive(false);
        bertInfo.SetActive(false);
        paulInfo.SetActive(false);
    }

    public void BobInfo()
    {
        bobInfo.SetActive(true);
        esmeeInfo.SetActive(false);
        bertInfo.SetActive(false);
        paulInfo.SetActive(false);
    }

    public void BertInfo()
    {
        bertInfo.SetActive(true);
        esmeeInfo.SetActive(false);
        bobInfo.SetActive(false);
        paulInfo.SetActive(false);
    }

    public void PaulInfo()
    {
        paulInfo.SetActive(true);
        esmeeInfo.SetActive(false);
        bobInfo.SetActive(false);
        bertInfo.SetActive(false);
    }
}
