using UnityEngine;

public class ShopOwner : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("Take this and move away please.");
                break;
            case NPCType.Farmer:
                Debug.Log("Hey, have any grain for me to sell?");
                break;
            case NPCType.ShopOwner:
                Debug.Log("Todays been slow hasn't it.");
                break;
            case NPCType.Lord:
                Debug.Log("Ah, my Lord, here to buy something?");
                break;
            case NPCType.Thief:
                Debug.Log("Go away.");
                break;
            case NPCType.Guard:
                Debug.Log("Safer when you're here.");
                break;
        }
    }
}
