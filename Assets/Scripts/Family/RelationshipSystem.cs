using UnityEngine;

namespace VortexLifeSim.Family
{
    public enum RelationshipStatus
    {
        Single,
        Dating,
        Married,
        Divorced
    }

    public class RelationshipSystem : MonoBehaviour
    {
        public RelationshipStatus status = RelationshipStatus.Single;
        public string partnerName = "";
        public int relationshipScore = 0;

        public void Meet(string newPartner)
        {
            partnerName = newPartner;
            status = RelationshipStatus.Dating;
            relationshipScore = 50;
            Debug.Log("Player is now dating " + partnerName + ".");
        }

        public void Marry()
        {
            if (status != RelationshipStatus.Dating)
            {
                Debug.Log("Cannot marry without a partner.");
                return;
            }

            status = RelationshipStatus.Married;
            Debug.Log("Player married " + partnerName + ".");
        }

        public void Divorce()
        {
            if (status == RelationshipStatus.Married)
            {
                status = RelationshipStatus.Divorced;
                partnerName = "";
                Debug.Log("Player divorced.");
            }
        }
    }
}
