using UnityEngine;

public class Thief : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("You don't have anything to take do you?");
                break;
            case NPCType.Farmer:
                Debug.Log("Give me your grain.");
                break;
            case NPCType.ShopOwner:
                Debug.Log("Give me your money.");
                break;
            case NPCType.Lord:
                Debug.Log("I don't think I can take your gaurds...");
                break;
            case NPCType.Thief:
                Debug.Log("Give me you're.... wait");
                break;
            case NPCType.Guard:
                Debug.Log("I'll stay away...");
                break;
        }
    }
}
