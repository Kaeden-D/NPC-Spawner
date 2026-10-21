using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.ShopOwner:
                INPC shopOwner = new ShopOwner();
                return shopOwner;
            case NPCType.Lord:
                INPC lord = new Lord();
                return lord;
            case NPCType.Thief:
                INPC thief = new Thief();
                return thief;
            case NPCType.Guard:
                INPC guard = new Guard();
                return guard;
        }
        return null;
    }
}
