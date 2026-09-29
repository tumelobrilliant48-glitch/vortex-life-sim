using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.Simulation
{
    [System.Serializable]
    public class JobDefinition
    {
        public string id;
        public string title;
        public int salary;
        public string workplaceName;
        public int requiredFitness;
        public int requiredEducationLevel;
    }

    public class JobSystem : MonoBehaviour
    {
        public List<JobDefinition> jobs = new List<JobDefinition>
        {
            new JobDefinition { id = "farm_worker", title = "Farm Worker", salary = 120, workplaceName = "Village Farm", requiredFitness = 15, requiredEducationLevel = 0 },
            new JobDefinition { id = "taxi_driver", title = "Taxi Driver", salary = 180, workplaceName = "Town Rank", requiredFitness = 20, requiredEducationLevel = 1 },
            new JobDefinition { id = "teacher", title = "Teacher", salary = 250, workplaceName = "Village School", requiredFitness = 10, requiredEducationLevel = 2 },
            new JobDefinition { id = "mechanic", title = "Mechanic", salary = 220, workplaceName = "Workshop", requiredFitness = 25, requiredEducationLevel = 1 }
        };

        public JobDefinition CurrentJob { get; private set; }

        public bool TryApplyForJob(string jobId, out JobDefinition selectedJob)
        {
            selectedJob = jobs.Find(job => job.id == jobId);

            if (selectedJob == null)
            {
                return false;
            }

            CurrentJob = selectedJob;
            return true;
        }

        public void CollectSalary()
        {
            if (CurrentJob == null)
            {
                return;
            }

            if (GameManager.Instance == null || GameManager.Instance.playerStats == null)
            {
                return;
            }

            GameManager.Instance.playerStats.money += CurrentJob.salary;
            Debug.Log("Player received salary: " + CurrentJob.salary + " from " + CurrentJob.title);
        }
    }
}
