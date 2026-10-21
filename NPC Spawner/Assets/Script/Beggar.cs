using UnityEngine;

public class Beggar : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("I wish there were more people who would help us.");
                break;
            case NPCType.Farmer:
                Debug.Log("Do you have some grain I could have?");
                break;
            case NPCType.ShopOwner:
                Debug.Log("Do you have some change to spare sir?");
                break;
            case NPCType.Lord:
                Debug.Log("Do you have some change to spare for me my Lord?");
                break;
            case NPCType.Thief:
                Debug.Log("I don't have anything for you to take.");
                break;
            case NPCType.Guard:
                Debug.Log("I don't know if I'm strong enough for being a guard.");
                break;
        }
    }
}
