using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.Education
{
    [System.Serializable]
    public class CourseDefinition
    {
        public string courseId;
        public string courseName;
        public int requiredLevel;
        public List<string> questions;
        public List<string> answers;
    }

    public class EducationSystem : MonoBehaviour
    {
        public List<CourseDefinition> courses = new List<CourseDefinition>
        {
            new CourseDefinition
            {
                courseId = "basic_math",
                courseName = "Basic Math",
                requiredLevel = 0,
                questions = new List<string>
                {
                    "2 + 2 = ?",
                    "10 - 3 = ?",
                    "5 * 5 = ?"
                },
                answers = new List<string>
                {
                    "4",
                    "7",
                    "25"
                }
            },
            new CourseDefinition
            {
                courseId = "driver_training",
                courseName = "Driver Training",
                requiredLevel = 1,
                questions = new List<string>
                {
                    "What is the first thing to do before driving?",
                    "What does a red traffic light mean?"
                },
                answers = new List<string>
                {
                    "Check mirrors and seat belts",
                    "Stop"
                }
            }
        };

        public int playerEducationLevel = 0;

        public bool EnrollInCourse(string courseId)
        {
            var selected = courses.Find(c => c.courseId == courseId);
            if (selected == null)
            {
                Debug.Log("Course not found.");
                return false;
            }

            Debug.Log("Enrolled in course: " + selected.courseName);
            return true;
        }

        public bool TakeExam(string courseId, List<string> studentAnswers)
        {
            var selected = courses.Find(c => c.courseId == courseId);
            if (selected == null)
            {
                return false;
            }

            int correctCount = 0;
            for (int i = 0; i < selected.answers.Count && i < studentAnswers.Count; i++)
            {
                if (string.Equals(selected.answers[i], studentAnswers[i], System.StringComparison.OrdinalIgnoreCase))
                {
                    correctCount++;
                }
            }

            float scorePercent = (correctCount / (float)selected.answers.Count) * 100f;
            if (scorePercent >= 70f)
            {
                playerEducationLevel = Mathf.Max(playerEducationLevel, selected.requiredLevel + 1);
                Debug.Log("Exam passed. New education level: " + playerEducationLevel);
                return true;
            }

            Debug.Log("Exam failed. Score: " + scorePercent + "%");
            return false;
        }
    }
}
