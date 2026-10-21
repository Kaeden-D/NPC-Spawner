using UnityEngine;

public class Lord : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("I apologize for you're suffering my subject, here's some coins.");
                break;
            case NPCType.Farmer:
                Debug.Log("Ahhh, How's the harvest?");
                break;
            case NPCType.ShopOwner:
                Debug.Log("Got any new wares shopkeep?");
                break;
            case NPCType.Lord:
                Debug.Log("What bring you here?");
                break;
            case NPCType.Thief:
                Debug.Log("What a pitiful profession.");
                break;
            case NPCType.Guard:
                Debug.Log("Do your best to keep me safe.");
                break;
        }
    }
}
