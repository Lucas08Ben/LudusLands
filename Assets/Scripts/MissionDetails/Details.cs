using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Details
{

    [SerializeField]
    private string missionTitle;

    [SerializeField]
    private string missionCity;

    [SerializeField]
    private string missionId;

    [SerializeField]
    [TextArea(1, 4)]
    private string missionContent;

    public string GetMissionTitle()
    {
        return this.missionTitle;
    }

    public string GetMissionCity()
    {
        return this.missionCity;
    }

    public string GetMissionId()
    {
        return this.missionId;
    }

    public string GeMissionContent()
    {
        return this.missionContent;
    }
}
