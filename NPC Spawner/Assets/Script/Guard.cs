using UnityEngine;

public class Guard : INPC
{
    public void Speak(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                Debug.Log("You might be able to become a guardsman.");
                break;
            case NPCType.Farmer:
                Debug.Log("Seen anyone supicious lately?");
                break;
            case NPCType.ShopOwner:
                Debug.Log("Have you been safe?");
                break;
            case NPCType.Lord:
                Debug.Log("I will protect you my Lord.");
                break;
            case NPCType.Thief:
                Debug.Log("Stay away or be arrested!");
                break;
            case NPCType.Guard:
                Debug.Log("Keep your gaurd up.");
                break;
        }
    }
}
