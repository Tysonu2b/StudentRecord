using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRecord
{
    class StudentData
    {
        public string firstName;
        public string lastName;
        public int age;
        public string classLevel;

       //Subjects
        public string subjectOne = "Maths";
        public string subjectTwo = "English";
        public string subjectThree = "Physics";
        public string subjectFour = "Chemistry";
        public string subjectFive = "Biology";
        public string subjectSix = "Economics";
        public string subjectSeven = "Civic Education";
        public string subjectEight= "Geography";
        public string subjectNine= "Calculus";

        // Declaring the Data Type for each Subject score
        public int subjectOneScore;
        public int subjectTwoScore;
        public int subjectThreeScore;
        public int subjectFourScore;
        public int subjectFiveScore;
        public int subjectSixScore;
        public int subjectSevenScore;
        public int subjectEightScore;
        public int subjectNineScore;
        public int totalScore;
        public int averageScore;

        public int[] scoreArray = new int[9];





        // Constructor of Student Data that takes all the class variables declared as parameter
        public StudentData(string aFirstName, string aLastName, int aAge, string aClassLevel, int asubjectOneScore, int asubjectTwoScore,
        int asubjectThreeScore, int asubjectFourScore, int asubjectFiveScore, int asubjectSixScore, int asubjectSevenScore, int asubjectEightScore, int asubjectNineScore)
        {
            this.firstName = aFirstName;
            this.lastName = aLastName;
            this.age = aAge;
            this.classLevel = aClassLevel;
            this.subjectOneScore = asubjectOneScore;
            this.subjectTwoScore = asubjectTwoScore;
            this.subjectThreeScore = asubjectThreeScore;
            this.subjectFourScore = asubjectFourScore;
            this.subjectFiveScore = asubjectFiveScore;
            this.subjectSixScore = asubjectSixScore;
            this.subjectSevenScore = asubjectSevenScore;
            this.subjectEightScore = asubjectEightScore;
            this.subjectNineScore = asubjectNineScore;
        }

        // Method to Calculate Total Score of Each Student
        public int Total(int subjectOneScore, int subjectTwoScore, int subjectThreeScore, int subjectFourScore, int subjectFiveScore, int subjectSixScore,
            int subjectSevenScore, int subjectEightScore, int subjectNineScore)
        {
            // initializing the scoreArray values for subjectScores
            scoreArray = new int[9] {subjectOneScore, subjectTwoScore, subjectThreeScore, subjectFourScore, subjectFiveScore, subjectSixScore,
                  subjectSevenScore, subjectEightScore, subjectNineScore};
            totalScore = 0;
            int j = 0;
            while (j <scoreArray.Length)
            {

                totalScore = totalScore + scoreArray[j];
                j++;
                
            }

            return totalScore;
        }

        // Method to Calculate Average Score of Each Student
        public int Average(int subjectOneScore, int subjectTwoScore, int subjectThreeScore, int subjectFourScore, int subjectFiveScore, int subjectSixScore,
            int subjectSevenScore, int subjectEightScore, int subjectNineScore)
        {


            averageScore = totalScore / scoreArray.Length; 
            return averageScore;
        }


        // Method to Calculate Student's Grade
        public string Grade()

        {
            string Grades = "";
            //integer array for scores scored by students. NOTE: the values of scoreArray corresponds with each element in subjectArray
            
            //string array declaration for subjects offered NOTE: the values of scoreArray corresponds with each element in subjectArray
            string[] subjectsTaken = {subjectOne, subjectTwo, subjectThree, subjectFour, subjectFive, subjectSix, subjectSeven, subjectEight, subjectNine};
            for (int i = 0; i < scoreArray.Length; i++)
            {
                  
                //If Conditional Statement to Calculate Students Grade for Each each score
                if (scoreArray[i] >= 75)

                {

                    char Grade1 = 'A';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1 );
                }

                else if (scoreArray[i] >= 65 && scoreArray[i] <= 74)
                {
                    char Grade1 = 'B';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1);
                }

                else if (scoreArray[i] >= 55 && scoreArray[i] <= 64 )
                {
                    char Grade1 = 'C';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1);
                }

                else if (scoreArray[i] >= 45 && scoreArray[i] <= 54)
                {
                    char Grade1 = 'D';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1);
                }

                else if (scoreArray[i] >= 41 && scoreArray[i] <= 44)
                {
                    char Grade1 = 'E';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1);
                }

                else
                {
                    char Grade1 = 'F';
                    Console.WriteLine(subjectsTaken[i] + " Score: " + scoreArray[i] + ", Grade: " + Grade1);
                }
              
            }

            return Grades;
        }
    }
}

