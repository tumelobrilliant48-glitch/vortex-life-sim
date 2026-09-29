using UnityEngine;

namespace VortexLifeSim.Interaction
{
    public class JobMarker : InteractableObject
    {
        public string jobId = "farm_worker";

        public override void Interact()
        {
            if (GameManager.Instance == null || GameManager.Instance.jobSystem == null)
            {
                Debug.Log("Job system not found.");
                return;
            }

            if (GameManager.Instance.jobSystem.TryApplyForJob(jobId, out var job))
            {
                Debug.Log("Player applied for job: " + job.title + " at " + job.workplaceName);
            }
            else
            {
                Debug.Log("Job not found: " + jobId);
            }
        }
    }
}
