using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private string npcName = "마을 주민?";

    [TextArea]
    [SerializeField] private string message = "여기 있었군 히스클리프!!";

    public string GetNPCName()
    {
        return npcName;
    }

    public string GetMessage()
    {
        return message;
    }

    public string GetGuideText()
    {
        return "[E] " + npcName + "와 대화하기";
    }
}
