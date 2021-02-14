using System;

namespace StudentRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an Instance of first Student Record       
            var tysonScore = new StudentData("Tyson", "Oghenevwere", 28, "SS3", 0, 41, 65, 65, 76, 88, 87, 90, 81);

            //Calling the method of Total score in the StudentData class by using the instantiated values of the object tysonScore  
            var tysonTotalScore = tysonScore.Total(tysonScore.subjectOneScore, tysonScore.subjectTwoScore, tysonScore.subjectThreeScore, tysonScore.subjectFourScore,
                tysonScore.subjectFiveScore, tysonScore.subjectSixScore, tysonScore.subjectSevenScore, tysonScore.subjectEightScore,
                tysonScore.subjectNineScore);

            //Calling the method of Average score in the StudentData class by using the instantiated values of the object tysonScore  
            var tysonAverage = tysonScore.Average(tysonScore.subjectOneScore, tysonScore.subjectTwoScore, tysonScore.subjectThreeScore, tysonScore.subjectFourScore,
               tysonScore.subjectFiveScore, tysonScore.subjectSixScore, tysonScore.subjectSevenScore, tysonScore.subjectEightScore,
               tysonScore.subjectNineScore);


            //Introductory Write Up for  before Tyson's Grade is Displayed
            Console.WriteLine("Student Record 1");
            Console.WriteLine();
            Console.WriteLine("Class Level: " + tysonScore.classLevel + " | Student's Age: " + tysonScore.age);
            Console.WriteLine("Hello" + " " + tysonScore.firstName + " " + tysonScore.lastName + " Your Exam Scores and Grades are as follow:" );
            Console.WriteLine("................................................");


            //Calling the grade method to printScore Grade
            tysonScore.Grade();

            
            Console.WriteLine("................................................");//Spacing the result to be displayed in the console
            Console.WriteLine("Your Total Summed Score Acquired in All Subject is: " + tysonTotalScore);

            Console.WriteLine();
            Console.WriteLine("................................................");//Spacing the result to be displayed in the console
            Console.WriteLine("Your Average: " + tysonAverage);
            Console.WriteLine();



            //New Student Record Begins from Here
            Console.WriteLine("Student Record 2");

            // Instantiation of the Student Data in the Main to Create a new Student Record
            var edesiriData = new StudentData("Edesiri", "Ovwori", 24, "SS2", 60, 19, 65, 44, 76, 69, 87, 90, 39);


           //Calling the method of Total score in the StudentData class by using the instantiated values of the object edesiriData  
            var edesiriTotalScore = edesiriData.Total(edesiriData.subjectOneScore, edesiriData.subjectTwoScore, edesiriData.subjectThreeScore, edesiriData.subjectFourScore,
                edesiriData.subjectFiveScore, edesiriData.subjectSixScore, edesiriData.subjectSevenScore, edesiriData.subjectEightScore,
                edesiriData.subjectNineScore);

            //Calling the method of Average score in the StudentData class by using the instantiated values of the object edesiriData  
            var edesiriAverage = edesiriData.Average(edesiriData.subjectOneScore, edesiriData.subjectTwoScore, edesiriData.subjectThreeScore, edesiriData.subjectFourScore,
               edesiriData.subjectFiveScore, edesiriData.subjectSixScore, edesiriData.subjectSevenScore, edesiriData.subjectEightScore,
               edesiriData.subjectNineScore);


            //Introductory Write Up for  before Edesiri's Grade is Displayed
            Console.WriteLine("Class Level: " + edesiriData.classLevel + " | Student's Age: " + edesiriData.age);
            Console.WriteLine("Hello" + " " + edesiriData.firstName + " " + edesiriData.lastName + " Your Exam Scores and Grades are as follow:");
            Console.WriteLine("................................................");
            
            //Calling the grade method to Edesiri's Grade
            edesiriData.Grade();

            //Spacing the result to be displayed on the console
            Console.WriteLine();
            Console.WriteLine("................................................");
            
            //Console Output for Edesiri's Total Score
            Console.WriteLine("Your Total Summed Score Acquired in All Subject is: " + edesiriTotalScore);

            Console.WriteLine();
            Console.WriteLine("................................................");//Spacing the result to be displayed in the console
            Console.WriteLine("Your Average: " + edesiriAverage);





            Console.ReadLine();
        }
    }
}
