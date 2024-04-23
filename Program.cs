int examAssignments = 5;

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int gradedAssignments = 0;

    int sumExtraAssignments = 0;

    decimal currentStudentGrade = 0;
    decimal sumExamGrade = 0;
    decimal sumExtraGrade = 0;
    decimal examGrade = 0;
    decimal extraGrade = 0;


    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamGrade += score;
        }
        else
        {
            sumExtraAssignments++;
            sumExtraGrade += score;
        }
    }

    examGrade = (decimal)sumExamGrade / examAssignments;
    extraGrade = (decimal)sumExtraGrade / sumExtraAssignments;

    currentStudentGrade = (decimal)((decimal)sumExamGrade + ((sumExtraGrade) / 10)) / examAssignments;

    decimal extraCreditValue = currentStudentGrade - examGrade; 

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{examGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{extraGrade} ({extraCreditValue} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
