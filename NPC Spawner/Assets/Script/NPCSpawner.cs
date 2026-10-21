using UnityEngine;

public class NPCSpawner : MonoBehaviour
{

    public NPCFactory m_Factory;

    private INPC m_Person1;
    private INPC m_Person2;

    public void SpawnVillagers()
    {

        NPCType person1 = randType(), person2 = randType();        

        m_Person1 = m_Factory.GetNPC(person1);
        m_Person2 = m_Factory.GetNPC(person2);

        Debug.Log(person1);
        m_Person1.Speak(person2);
        Debug.Log(person2);
        m_Person2.Speak(person1);

        Debug.Log("");

    }

    public NPCType randType()
    {
        switch (Random.Range(0, 6))
        {
            case 0:
                return NPCType.Farmer;
            case 1:
                return NPCType.Beggar;
            case 2:
                return NPCType.ShopOwner;
            case 3:
                return NPCType.Lord;
            case 4:
                return NPCType.Thief;
            case 5:
                return NPCType.Guard;
        }
        return NPCType.Farmer; //Cannot be called anyways
    }

}
