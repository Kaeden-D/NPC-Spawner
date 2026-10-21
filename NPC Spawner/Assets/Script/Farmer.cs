using UnityEngine;

public class Farmer : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("Here's some grain for the day.");
                break;
            case NPCType.Farmer:
                Debug.Log("How's the fields and family?");
                break;
            case NPCType.ShopOwner:
                Debug.Log("The harvest is looking good so maybe soon.");
                break;
            case NPCType.Lord:
                Debug.Log("The yield seems good my Lord.");
                break;
            case NPCType.Thief:
                Debug.Log("The yield isn't even up yet.");
                break;
            case NPCType.Guard:
                Debug.Log("No one suspicious recently I think.");
                break;
        }
    }
}
